using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class InvoiceTotal : Form
    {
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var subtotal = Decimal.Parse(txtSubtotal.Text);
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
            txtDiscountAmount.Text = discountAmount.ToString();
            txtTotal.Text = invoiceTotal.ToString();

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}