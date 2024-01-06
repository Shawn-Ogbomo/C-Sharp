namespace InvoiceTotal
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtEnterSubtotal = new System.Windows.Forms.TextBox();
            txtDiscountPercent = new System.Windows.Forms.TextBox();
            txtDiscountAmount = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            txtInvoiceAverage = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnClearTotals = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter &Subtotal:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Discount Percent:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Discount Amount:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 141);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnterSubtotal
            // 
            txtEnterSubtotal.Location = new System.Drawing.Point(122, 22);
            txtEnterSubtotal.Name = "txtEnterSubtotal";
            txtEnterSubtotal.Size = new System.Drawing.Size(100, 23);
            txtEnterSubtotal.TabIndex = 1;
            txtEnterSubtotal.TextChanged += txtEnterSubtotal_TextChanged;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new System.Drawing.Point(122, 80);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new System.Drawing.Size(100, 23);
            txtDiscountPercent.TabIndex = 10;
            txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new System.Drawing.Point(122, 109);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new System.Drawing.Size(100, 23);
            txtDiscountAmount.TabIndex = 11;
            txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(122, 137);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(100, 23);
            txtTotal.TabIndex = 12;
            txtTotal.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(11, 54);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Subtotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(258, 54);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(114, 15);
            label6.TabIndex = 14;
            label6.Text = "Number of invoices:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(258, 83);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 15);
            label7.TabIndex = 15;
            label7.Text = "Total of invoices:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(258, 112);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(92, 15);
            label8.TabIndex = 16;
            label8.Text = "Invoice average:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(122, 51);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(100, 23);
            txtSubtotal.TabIndex = 17;
            txtSubtotal.TabStop = false;
            // 
            // txtNumberOfInvoices
            // 
            txtNumberOfInvoices.Location = new System.Drawing.Point(378, 51);
            txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            txtNumberOfInvoices.ReadOnly = true;
            txtNumberOfInvoices.Size = new System.Drawing.Size(100, 23);
            txtNumberOfInvoices.TabIndex = 18;
            txtNumberOfInvoices.TabStop = false;
            // 
            // txtTotalOfInvoices
            // 
            txtTotalOfInvoices.Location = new System.Drawing.Point(378, 80);
            txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            txtTotalOfInvoices.ReadOnly = true;
            txtTotalOfInvoices.Size = new System.Drawing.Size(100, 23);
            txtTotalOfInvoices.TabIndex = 19;
            txtTotalOfInvoices.TabStop = false;
            // 
            // txtInvoiceAverage
            // 
            txtInvoiceAverage.Location = new System.Drawing.Point(378, 109);
            txtInvoiceAverage.Name = "txtInvoiceAverage";
            txtInvoiceAverage.ReadOnly = true;
            txtInvoiceAverage.Size = new System.Drawing.Size(100, 23);
            txtInvoiceAverage.TabIndex = 20;
            txtInvoiceAverage.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(219, 176);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(403, 176);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.Click += btnExit_Click;
            // 
            // btnClearTotals
            // 
            btnClearTotals.Location = new System.Drawing.Point(311, 176);
            btnClearTotals.Name = "btnClearTotals";
            btnClearTotals.Size = new System.Drawing.Size(75, 23);
            btnClearTotals.TabIndex = 21;
            btnClearTotals.Text = "Clear Totals";
            btnClearTotals.Click += btnClearTotals_Click;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(497, 214);
            Controls.Add(btnClearTotals);
            Controls.Add(txtInvoiceAverage);
            Controls.Add(txtTotalOfInvoices);
            Controls.Add(txtNumberOfInvoices);
            Controls.Add(txtSubtotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnterSubtotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInvoiceTotal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearTotals;
    }
}

