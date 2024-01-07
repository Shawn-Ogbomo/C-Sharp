﻿using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = .0m;

            if (customerType == "R" || customerType == "r")
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
            }
            else if (customerType == "C" || customerType == "c")
            {
                discountPercent = .2m;
            }
            else if (customerType == "T" || customerType == "t")
            {
                if (subtotal < 500)
                {
                    discountPercent = .4m;
                }
                else
                {
                    discountPercent = .5m;
                }
            }
            else
            {
                discountPercent = .1m;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}