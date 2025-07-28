using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class Form2 : Form
    {
        public bool PaymentConfirmed { get; private set; } = false;
        public Form2(Form1.Invoice invoice)
        {
            InitializeComponent();
            lblCustomerName.Text = $"Customer Name: {invoice.CustomerName}";
            lblCustomerType.Text = $"Customer Type: {invoice.CustomerType}";
            lblTotalWaterBill.Text = $"Total Water Bill: {invoice.WaterMoney:N0} VND";
            lblPaymentTime.Text = $"Payment Time: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

            if (invoice.CustomerType == "Household customer")
                lblNumberOfPeople.Text = $"Number of People: {invoice.NumberOfPeople}";
            else
                lblNumberOfPeople.Text = "";
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            PaymentConfirmed = true;
            MessageBox.Show("Payment successful!", "Success");
            this.Close();
        }
    }
}
