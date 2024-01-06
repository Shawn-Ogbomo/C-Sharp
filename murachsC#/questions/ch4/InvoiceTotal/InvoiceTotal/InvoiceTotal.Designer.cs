namespace InvoiceTotal
{
    partial class InvoiceTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceTotal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.txtNumInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinInvoice = new System.Windows.Forms.TextBox();
            this.txtMaxInvoice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.DimGray;
            this.txtSubtotal.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtSubtotal, "txtSubtotal");
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.TabStop = false;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.BackColor = System.Drawing.Color.DimGray;
            this.txtDiscountPercent.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtDiscountPercent, "txtDiscountPercent");
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.BackColor = System.Drawing.Color.DimGray;
            this.txtDiscountAmount.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtDiscountAmount, "txtDiscountAmount");
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.DimGray;
            this.txtTotal.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.BackColor = System.Drawing.Color.DimGray;
            this.txtEnterSubtotal.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtEnterSubtotal, "txtEnterSubtotal");
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            // 
            // txtNumInvoices
            // 
            this.txtNumInvoices.BackColor = System.Drawing.Color.DimGray;
            this.txtNumInvoices.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtNumInvoices, "txtNumInvoices");
            this.txtNumInvoices.Name = "txtNumInvoices";
            this.txtNumInvoices.ReadOnly = true;
            this.txtNumInvoices.TabStop = false;
            // 
            // txtTotalInvoices
            // 
            this.txtTotalInvoices.BackColor = System.Drawing.Color.DimGray;
            this.txtTotalInvoices.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtTotalInvoices, "txtTotalInvoices");
            this.txtTotalInvoices.Name = "txtTotalInvoices";
            this.txtTotalInvoices.ReadOnly = true;
            this.txtTotalInvoices.TabStop = false;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.BackColor = System.Drawing.Color.DimGray;
            this.txtInvoiceAverage.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtInvoiceAverage, "txtInvoiceAverage");
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtMinInvoice
            // 
            this.txtMinInvoice.BackColor = System.Drawing.Color.DimGray;
            this.txtMinInvoice.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtMinInvoice, "txtMinInvoice");
            this.txtMinInvoice.Name = "txtMinInvoice";
            this.txtMinInvoice.ReadOnly = true;
            this.txtMinInvoice.TabStop = false;
            this.txtMinInvoice.TextChanged += new System.EventHandler(this.txtMinInvoice_TextChanged);
            // 
            // txtMaxInvoice
            // 
            this.txtMaxInvoice.BackColor = System.Drawing.Color.DimGray;
            this.txtMaxInvoice.ForeColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.txtMaxInvoice, "txtMaxInvoice");
            this.txtMaxInvoice.Name = "txtMaxInvoice";
            this.txtMaxInvoice.ReadOnly = true;
            this.txtMaxInvoice.TabStop = false;
            this.txtMaxInvoice.TextChanged += new System.EventHandler(this.txtMaxInvoice_TextChanged);
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.CancelButton = this.btnExit;
            this.Controls.Add(this.txtMaxInvoice);
            this.Controls.Add(this.txtMinInvoice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalInvoices);
            this.Controls.Add(this.txtNumInvoices);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LightPink;
            this.KeyPreview = true;
            this.Name = "InvoiceTotal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.TextBox txtNumInvoices;
        private System.Windows.Forms.TextBox txtTotalInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinInvoice;
        private System.Windows.Forms.TextBox txtMaxInvoice;
    }
}

