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
        public const double ENV_FEE = 0.1;


        // ====== Data ======
        private List<Invoice> invoices = new List<Invoice>();

        // ====== Configuration ======
        private static readonly Dictionary<string, double> Rates = new Dictionary<string, double>
        {
            { "Administrative agency, public services", 9955 },
            { "Production units", 11615 },
            { "Business services", 22068 }
        };

        // ====== Constructor ======
        public Form1()
        {
            InitializeComponent();


            if (cboTypeOfCustomer.Items.Count == 0)
            {
                cboTypeOfCustomer.Items.AddRange(new string[]
                {
                    "Household customer",
                    "Administrative agency, public services",
                    "Production units",
                    "Business services"
                });
            }
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;


            if (lvWaterBill.Columns.Count == 0)
            {
                lvWaterBill.View = View.Details;
                lvWaterBill.Columns.Add("Customer Name", 200);
                lvWaterBill.Columns.Add("Last Month Water Meter", 200);
                lvWaterBill.Columns.Add("This Month Water Meter", 200);
                lvWaterBill.Columns.Add("Amount Of Consumption", 200);
                lvWaterBill.Columns.Add("Total Water Bill", 200);
                lvWaterBill.Columns.Add("Status", 150);
            }


            txtCustomerName.TextChanged += ValidateInput;
            txtNumberOfPeople.TextChanged += ValidateInput;
            txtLastMonthWaterMeter.TextChanged += ValidateInput;
            txtThisMonthWaterMeter.TextChanged += ValidateInput;
            txtSearch.TextChanged += txtSearch_TextChanged;

            var tooltip = new ToolTip();
            tooltip.SetToolTip(txtCustomerName, "Only enter letters and spaces.");
            tooltip.SetToolTip(txtLastMonthWaterMeter, "Enter a non-negative number.");
            tooltip.SetToolTip(txtThisMonthWaterMeter, "Enter a non-negative number.");
            tooltip.SetToolTip(txtNumberOfPeople, "Enter a positive number if Household customer.");
        }

        // ====== Validation ======
        private void ValidateInput(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            bool isValid = true;

            if (txt == txtCustomerName)
            {
                string name = txt.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    errorProvider1.SetError(txt, "Name cannot be empty or just spaces.");
                    isValid = false;
                }
                else if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                {
                    errorProvider1.SetError(txt, "Name must contain only letters and spaces.");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txt, "");
                }
            }
            else if (txt == txtNumberOfPeople && cboTypeOfCustomer.Text == "Household customer")
            {
                if (!int.TryParse(txt.Text, out int num) || num <= 0)
                {
                    errorProvider1.SetError(txt, "Enter a positive integer.");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txt, "");
                }
            }
            else if (txt == txtLastMonthWaterMeter || txt == txtThisMonthWaterMeter)
            {
                if (!double.TryParse(txt.Text, out double value) || value < 0)
                {
                    errorProvider1.SetError(txt, "Enter a non-negative number.");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txt, "");
                }
            }

            // Change textbox color if invalid
            txt.BackColor = isValid ? Color.White : Color.LightPink;
        }


        // ====== Window Controls ======
        private void iconexit_Click(object sender, EventArgs e) => Application.Exit();
        private void iconminimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // iconrestaurar.Visible = true; iconmaximizar.Visible = false; 
        }
        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            // iconrestaurar.Visible = false; iconmaximizar.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtNumberOfPeople.Clear();
            txtLastMonthWaterMeter.Clear();
            txtThisMonthWaterMeter.Clear();
            cboTypeOfCustomer.SelectedIndex = -1;
            errorProvider1.Clear();
            txtCustomerName.Focus();
        }

        // ====== Customer Type Selection ======
        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isHousehold = cboTypeOfCustomer.Text == "Household customer";
            txtNumberOfPeople.Enabled = isHousehold;
            if (!isHousehold)
            {
                txtNumberOfPeople.Clear();
                errorProvider1.SetError(txtNumberOfPeople, "");
            }
        }

        // ====== Add Invoice ======
        private void btnCaculator_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtCustomerName.Text.Trim();
                string customerType = cboTypeOfCustomer.Text;
                int numberOfPeople = 0;
                double lastMonthWaterMeter = 0, thisMonthWaterMeter = 0;

                ValidateInput(txtCustomerName, EventArgs.Empty);

                if (string.IsNullOrEmpty(customerName) || !Regex.IsMatch(customerName, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid customer name.", "Validation Error");
                    return;
                }

                if (string.IsNullOrEmpty(customerType))
                {
                    MessageBox.Show("Please select customer type.", "Validation Error");
                    return;
                }
                if (customerType == "Household customer" && (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0))
                {
                    MessageBox.Show("Please enter a valid number of people.", "Validation Error");
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

                var (consumption, totalBill) = Calculator(customerType, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter);
                ListViewItem item = new ListViewItem(customerName);
                item.SubItems.Add(lastMonthWaterMeter.ToString());
                item.SubItems.Add(thisMonthWaterMeter.ToString());
                item.SubItems.Add(consumption.ToString());
                item.SubItems.Add(totalBill.ToString());
                item.SubItems.Add("Unpaid");
                lvWaterBill.Items.Add(item);

                invoices.Add(new Invoice
                {
                    CustomerName = customerName,
                    CustomerType = customerType,
                    NumberOfPeople = numberOfPeople,
                    LastMonthWaterMeter = lastMonthWaterMeter,
                    ThisMonthWaterMeter = thisMonthWaterMeter,
                    Consumption = consumption,
                    WaterMoney = totalBill
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error");
            }
        }

        // ====== Calculator ======
        private double CalculateHouseholdWaterMoney(double consumption, int numberOfPeople)
        {
            double avg = consumption / numberOfPeople;
            double waterMoney = 0;
            if (avg <= 10)
                waterMoney = avg * 5973 * numberOfPeople;
            else if (avg > 10 && avg <= 20)
                waterMoney = (10 * 5973 + (avg - 10) * 7052) * numberOfPeople;
            else if (avg > 20 && avg <= 30)
                waterMoney = (10 * 5973 + 10 * 7052 + (avg - 20) * 8699) * numberOfPeople;
            else
                waterMoney = (10 * 5973 + 10 * 7052 + 10 * 8699 + (avg - 30) * 15929) * numberOfPeople;
            return waterMoney;
        }

        private (double, double) Calculator(string customerType, int numberOfPeople, double lastMonthWaterMeter, double thisMonthWaterMeter)
        {
            try
            {
                double consumption = thisMonthWaterMeter - lastMonthWaterMeter;
                if (consumption < 0)
                    throw new ArgumentException("Consumption cannot be negative.");

                double waterMoney = 0;
                if (customerType == "Household customer")
                {
                    waterMoney = CalculateHouseholdWaterMoney(consumption, numberOfPeople);
                }
                else
                {
                    if (Rates.ContainsKey(customerType))
                        waterMoney = consumption * Rates[customerType];
                    else
                        throw new ArgumentException("Invalid customer type.");
                }

                double withEnvFee = waterMoney + (waterMoney * ENV_FEE);

              
                double totalBill = withEnvFee + (withEnvFee * VAT);

                return (consumption, totalBill);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Calculation Error");
                return (0, 0);
            }
        }

        // ====== Pay Invoice ======
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an invoice to pay.", "No Invoice Selected");
                return;
            }

            var selectedItem = lvWaterBill.SelectedItems[0];
            int index = selectedItem.Index;
            if (index >= 0 && index < invoices.Count)
            {
                Invoice selected = invoices[index];

                if (selected.IsPaid)
                {
                    MessageBox.Show("This invoice has already been paid.", "Notice");
                    return;
                }

                if (MessageBox.Show("Do you want to proceed with the payment?", "Payment Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Customer Name: {selected.CustomerName}");
                    sb.AppendLine($"Customer Type: {selected.CustomerType}");
                    if (selected.CustomerType == "Household customer")
                        sb.AppendLine($"Number of People: {selected.NumberOfPeople}");

                    sb.AppendLine($"Total Water Bill: {selected.WaterMoney:N0} VND");
                    sb.AppendLine($"Payment Time: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");

                    MessageBox.Show(sb.ToString(), "Payment Successful");

                   
                    selected.IsPaid = true;
                    selectedItem.SubItems[5].Text = "Paid";
                    selectedItem.BackColor = Color.LightGreen;
                }
            }
            else
            {
                MessageBox.Show("Invalid invoice index.", "Error");

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

            var filteredInvoices = invoices
                .Where(inv => string.IsNullOrEmpty(search) || inv.CustomerName.ToLower().Contains(search))
                .ToList();

            filteredInvoices.ForEach(AddInvoiceToListView);

            if (!filteredInvoices.Any())
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
            item.SubItems.Add(invoice.IsPaid ? "Paid" : "Unpaid");

            item.Tag = invoice;

            if (invoice.IsPaid)
            {
                item.BackColor = Color.LightGreen;
            }

            lvWaterBill.Items.Add(item);
        }

        // ====== Invoice Class ======
        public class Invoice
        {
            public string CustomerType { get; set; }
            public int NumberOfPeople { get; set; }
            public string CustomerName { get; set; }
            public double LastMonthWaterMeter { get; set; }
            public double ThisMonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double WaterMoney { get; set; }
            public bool IsPaid { get; set; } = false;
            
        }
        
    }
}
