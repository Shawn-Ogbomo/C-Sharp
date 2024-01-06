using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class InvoiceTotal : Form
    {
        //public members
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        //private members
        private static int invoiceCount = 0;

        private static void IncrementInvoiceCount()
        {
            ++invoiceCount;
        }

        private static void ResetInvoiceCount()
        {
            invoiceCount = 0;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            var subtotal = Decimal.Parse(txtEnterSubtotal.Text);
            decimal discountPercent = 0m;

            if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 500)
            {
                discountPercent = .2m;
            }

            decimal discountAmount = Decimal.Round(subtotal * discountPercent, 2);
            decimal invoiceTotal = Decimal.Round(subtotal - discountAmount, 2);

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
            txtSubtotal.Text = subtotal.ToString("c");

            IncrementInvoiceCount();
            txtNumInvoices.Text = invoiceCount.ToString();

            txtSubtotal.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNumInvoices.Text = "";
            txtTotalInvoices.Text = "";
            txtInvoiceAverage.Text = "";
            ResetInvoiceCount();
        }
    }
}