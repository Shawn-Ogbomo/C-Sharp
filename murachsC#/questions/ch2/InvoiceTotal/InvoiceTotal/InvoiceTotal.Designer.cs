﻿namespace InvoiceTotal
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.BackColor = System.Drawing.Color.Gray;
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSubtotal
            // 
            resources.ApplyResources(this.txtSubtotal, "txtSubtotal");
            this.txtSubtotal.BackColor = System.Drawing.Color.DimGray;
            this.txtSubtotal.ForeColor = System.Drawing.Color.LightPink;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDiscountPercent
            // 
            resources.ApplyResources(this.txtDiscountPercent, "txtDiscountPercent");
            this.txtDiscountPercent.BackColor = System.Drawing.Color.DimGray;
            this.txtDiscountPercent.ForeColor = System.Drawing.Color.LightPink;
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.TabStop = false;
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDiscountAmount
            // 
            resources.ApplyResources(this.txtDiscountAmount, "txtDiscountAmount");
            this.txtDiscountAmount.BackColor = System.Drawing.Color.DimGray;
            this.txtDiscountAmount.ForeColor = System.Drawing.Color.LightPink;
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.TabStop = false;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBoxTotal
            // 
            resources.ApplyResources(this.txtBoxTotal, "txtBoxTotal");
            this.txtBoxTotal.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxTotal.ForeColor = System.Drawing.Color.LightPink;
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.TabStop = false;
            this.txtBoxTotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.CancelButton = this.btnExit;
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LightPink;
            this.KeyPreview = true;
            this.Name = "InvoiceTotal";
            this.Load += new System.EventHandler(this.InvoiceTotal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtBoxTotal;
    }
}

