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
        private int invoiceCount = 0;

        private decimal total = 0;

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

            var discountAmount = Decimal.Round(subtotal * discountPercent, 2);
            var invoiceTotal = Decimal.Round(subtotal - discountAmount, 2);

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
            txtSubtotal.Text = subtotal.ToString("c");

            ++invoiceCount;
            txtNumInvoices.Text = invoiceCount.ToString();

            total += invoiceTotal;
            txtTotalInvoices.Text = total.ToString("c");

            txtInvoiceAverage.Text = (total / invoiceCount).ToString("c");
            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
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
            invoiceCount = 0;
            total = 0;
        }
    }
}