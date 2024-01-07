using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text.ToUpper();
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = .0m;

            switch (customerType)
            {
                case "R":
                    {
                        if (subtotal < 100)
                        {
                            discountPercent = .0m;
                        }
                        else if (subtotal >= 100 && subtotal < 250)
                        {
                            discountPercent = .1m;
                        }
                        else if (subtotal >= 250 && subtotal < 500)
                        {
                            discountPercent = .25m;
                        }
                        else
                        {
                            discountPercent = .30m;
                        }
                        break;
                    }
                case "C":
                    {
                        discountPercent = .2m;
                        break;
                    }

                case "T":
                    {
                        if (subtotal < 500)
                        {
                            discountPercent = .4m;
                        }
                        else
                        {
                            discountPercent = .5m;
                        }
                        break;
                    }
                default:
                    {
                        discountPercent = .1m;
                        break;
                    }
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}