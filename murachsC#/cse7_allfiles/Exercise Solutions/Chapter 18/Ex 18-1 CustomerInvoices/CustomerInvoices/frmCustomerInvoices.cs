﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInvoices
{
    public partial class frmCustomerInvoices : Form
    {
        public frmCustomerInvoices()
        {
            InitializeComponent();
        }

        private void frmCustomerInvoices_Load(object sender, EventArgs e)
        {
            List<Customer> customerList = CustomerDB.GetCustomers();
            List<Invoice> invoiceList = InvoiceDB.GetInvoices();

            var invoices = from invoice in invoiceList
                           join customer in customerList
                           on invoice.CustomerID equals customer.CustomerID
                           orderby customer.Name, invoice.InvoiceTotal descending
                           select new
                           {
                               customer.Name,
                               invoice.InvoiceID,
                               invoice.InvoiceDate,
                               invoice.InvoiceTotal
                           };

            string customerName = "";
            int i = 0;
            foreach (var invoice in invoices)
            {
                if (invoice.Name != customerName)
                {
                    lvInvoices.Items.Add(invoice.Name);
                    customerName = invoice.Name;
                }
                else
                {
                    lvInvoices.Items.Add("");
                }
                lvInvoices.Items[i].SubItems.Add(invoice.InvoiceID.ToString());
                lvInvoices.Items[i].SubItems.Add(
                    Convert.ToDateTime(invoice.InvoiceDate).ToShortDateString());
                lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                i += 1;
            }
        }

    }
}
