using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class Form1 : Form
    {
        // ====== Constants ======
        public const double VAT = 0.1;

        // ====== Data ======
        private List<Invoice> invoices;

        // ====== Constructor ======
        public Form1()
        {
            InitializeComponent();
            invoices = new List<Invoice>();
        }

        // ====== Form Load ======
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách loại khách hàng
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administrative agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");
        

            // Cài đặt hiển thị danh sách hóa đơn
            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("Last Month Water Meter", 200);
            lvWaterBill.Columns.Add("This Month Water Meter", 200);
            lvWaterBill.Columns.Add("Amount Of Consumption", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);
            lvWaterBill.Columns.Add("Status", 150);

            // Tooltip hướng dẫn nhập liệu
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtCustomerName, "Only enter letters and spaces.");
            tooltip.SetToolTip(txtLastMonthWaterMeter, "Enter a non-negative number.");
            tooltip.SetToolTip(txtThisMonthWaterMeter, "Enter a non-negative number.");
            tooltip.SetToolTip(txtNumberOfPeople, "Enter a positive number if Household customer.");

            txtCustomerName.TextChanged += ValidateCustomerName;
            txtNumberOfPeople.TextChanged += ValidateNumberOfPeople;
            txtLastMonthWaterMeter.TextChanged += ValidateWaterMeter;
            txtThisMonthWaterMeter.TextChanged += ValidateWaterMeter;

        }

        private void ValidateCustomerName(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtCustomerName, "Name cannot be empty or just spaces.");
            }
            
            else if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                errorProvider1.SetError(txtCustomerName, "Name must contain only letters and spaces.");
            }
            else
            {
                errorProvider1.SetError(txtCustomerName, "");
            }
        }


        private void ValidateNumberOfPeople(object sender, EventArgs e)
        {
            if (cboTypeOfCustomer.Text == "Household customer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out int num) || num <= 0)
                {
                    errorProvider1.SetError(txtNumberOfPeople, "Enter a positive integer.");
                }
                else
                {
                    errorProvider1.SetError(txtNumberOfPeople, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtNumberOfPeople, "");
            }
        }

        private void ValidateWaterMeter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!double.TryParse(txt.Text, out double value) || value < 0)
            {
                errorProvider1.SetError(txt, "Enter a non-negative number.");
            }
            else
            {
                errorProvider1.SetError(txt, "");
            }
        }





        // ====== Window Controls ======
        private void iconexit_Click(object sender, EventArgs e) => Application.Exit();
        private void iconminimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ nội dung trong các ô nhập liệu
            txtCustomerName.Clear();
            txtNumberOfPeople.Clear();
            txtLastMonthWaterMeter.Clear();
            txtThisMonthWaterMeter.Clear();
            cboTypeOfCustomer.SelectedIndex = -1;

            // Xóa lỗi hiển thị nếu có
            errorProvider1.Clear();

            // Ẩn nhãn thông tin thanh toán nếu đang hiển thị
            lblPaymentInfo.Text = "";
            lblPaymentInfo.Visible = false;

            // Focus lại vào ô nhập đầu tiên
            txtCustomerName.Focus();
        }

        // ====== Customer Type Selection ======
        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isHousehold = cboTypeOfCustomer.Text == "Household customer";

            txtNumberOfPeople.ReadOnly = !isHousehold;

            if (!isHousehold)
            {
                txtNumberOfPeople.Clear();
                errorProvider1.SetError(txtNumberOfPeople, "");
            }
        }


        // ====== Add Invoice ======
        private void btnCaculator_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu người dùng
            string customerName = txtCustomerName.Text.Trim();
            string customerType = cboTypeOfCustomer.Text;
            int numberOfPeople = 0;
            double lastMonthWaterMeter = 0;
            double thisMonthWaterMeter = 0;

            // Kiểm tra hợp lệ
            if (string.IsNullOrEmpty(customerName) || Regex.IsMatch(customerName, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter a valid customer name (letters and spaces only).", "Validation Error");
                return;
            }

            if (customerType == "")
            {
                MessageBox.Show("Please select customer type.", "Validation Error");
                return;
            }

            if (customerType == "Household customer" &&
                (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0))
            {
                MessageBox.Show("Please enter a valid number of people (positive integer).", "Validation Error");
                return;
            }

            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) || lastMonthWaterMeter < 0 ||
                !double.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || thisMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter valid water meter readings.", "Validation Error");
                return;
            }

            if (thisMonthWaterMeter < lastMonthWaterMeter)
            {
                MessageBox.Show("This month's water meter cannot be less than last month's.", "Validation Error");
                return;
            }

            // Tính tiền nước
            var result = Calculator(customerType, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter);
            double consumption = result.Item1;
            double totalBill = result.Item2;

            // Thêm vào ListView
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthWaterMeter.ToString());
            item.SubItems.Add(thisMonthWaterMeter.ToString());
            item.SubItems.Add(consumption.ToString());
            item.SubItems.Add(totalBill.ToString());
            item.SubItems.Add("Unpaid");
            lvWaterBill.Items.Add(item);

            // Lưu dữ liệu hóa đơn
            invoices.Add(new Invoice
            {
                CustomerName = customerName,
                LastMonthWaterMeter = lastMonthWaterMeter,
                ThisMonthWaterMeter = thisMonthWaterMeter,
                Consumption = consumption,
                WaterMoney = totalBill
            });
        }

        // ====== Calculator ======
        private (double, double) Calculator(string customerType, int numberOfPeople, double lastMonthWaterMeter, double thisMonthWaterMeter)
        {
            double consumption = thisMonthWaterMeter - lastMonthWaterMeter;
            double waterMoney = 0;

            if (customerType == "Household customer")
            {
                double avg = consumption / numberOfPeople;

                if (avg < 10)
                    waterMoney = avg * 5973 * numberOfPeople;
                else if (avg < 20)
                    waterMoney = (10 * 5973 + (avg - 10) * 7052) * numberOfPeople;
                else if (avg < 30)
                    waterMoney = (10 * 5973 + 10 * 7052 + (avg - 20) * 8699) * numberOfPeople;
                else
                    waterMoney = (10 * 5973 + 10 * 7052 + 10 * 8699 + (avg - 30) * 15929) * numberOfPeople;
            }
            else
            {
                double rate = 0;

                if (customerType == "Administrative agency, public services")
                    rate = 9955;
                else if (customerType == "Production units")
                    rate = 11615;
                else if (customerType == "Business services")
                    rate = 22068;

                waterMoney = consumption * rate;
            }

            double withEnvFee = waterMoney * 1.1;           // +10% phí môi trường
            double totalBill = withEnvFee * (1 + VAT);      // +10% VAT

            return (consumption, totalBill);
        }


        // ====== Pay Invoice ======
        private void btnPay_Click_1(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an invoice to pay.", "No Invoice Selected");
                return;
            }

            if (MessageBox.Show("Do you want to proceed with the payment?", "Payment Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = lvWaterBill.SelectedItems[0].Index;
                Invoice selected = invoices[index];

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("✅ Payment Details:");
                sb.AppendLine($"Customer Name: {selected.CustomerName}");
                sb.AppendLine($"Customer Type: {cboTypeOfCustomer.Text}");

                if (cboTypeOfCustomer.Text == "Household customer")
                    sb.AppendLine($"Number of People: {txtNumberOfPeople.Text}");

                sb.AppendLine($"Total Water Bill: {selected.WaterMoney:N0} VND");
                sb.AppendLine($"Payment Time: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");

                // Hiển thị thông báo thanh toán thành công kèm thông tin
                MessageBox.Show(sb.ToString(), "Payment Successful");

                // Cập nhật trạng thái hóa đơn
                lvWaterBill.Items[index].SubItems[5].Text = "Paid";
                lvWaterBill.Items[index].BackColor = Color.LightGreen;
            }
        }

        // ====== Delete Invoice ======
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an invoice to delete.", "No Selection");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this invoice?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = lvWaterBill.SelectedItems[0].Index;
                lvWaterBill.Items.RemoveAt(index);
                invoices.RemoveAt(index);
            }
        }

        // ====== Search ======
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();
            lvWaterBill.Items.Clear();

            foreach (Invoice invoice in invoices)
            {
                if (string.IsNullOrEmpty(search) || invoice.CustomerName.ToLower().Contains(search))
                {
                    AddInvoiceToListView(invoice);
                }
            }

            if (!invoices.Any(inv => inv.CustomerName.ToLower().Contains(search)))
            {
                MessageBox.Show("No matching result found.", "Search");
            }
        }

        // ====== Utility ======
        private void AddInvoiceToListView(Invoice invoice)
        {
            ListViewItem item = new ListViewItem(invoice.CustomerName);
            item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
            item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
            item.SubItems.Add(invoice.Consumption.ToString());
            item.SubItems.Add(invoice.WaterMoney.ToString());
            item.SubItems.Add("Unpaid");
            lvWaterBill.Items.Add(item);
        }

        // ====== Invoice Class ======
        public class Invoice
        {
            public string CustomerName { get; set; }
            public double LastMonthWaterMeter { get; set; }
            public double ThisMonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double WaterMoney { get; set; }
        }
    }
}
