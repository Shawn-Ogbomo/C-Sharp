namespace FinancialCalculations
{
    partial class frmInvestment
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            rdoMonthlyInvestment = new System.Windows.Forms.RadioButton();
            rdoFutureValue = new System.Windows.Forms.RadioButton();
            btnExit = new System.Windows.Forms.Button();
            btnCalculate = new System.Windows.Forms.Button();
            txtYears = new System.Windows.Forms.TextBox();
            txtInterestRate = new System.Windows.Forms.TextBox();
            txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            txtFutureValue = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoMonthlyInvestment);
            groupBox1.Controls.Add(rdoFutureValue);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(303, 58);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate";
            // 
            // rdoMonthlyInvestment
            // 
            rdoMonthlyInvestment.Location = new System.Drawing.Point(149, 28);
            rdoMonthlyInvestment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoMonthlyInvestment.Name = "rdoMonthlyInvestment";
            rdoMonthlyInvestment.Size = new System.Drawing.Size(140, 24);
            rdoMonthlyInvestment.TabIndex = 1;
            rdoMonthlyInvestment.Text = "Monthly investment";
            rdoMonthlyInvestment.CheckedChanged += rdoMonthlyInvestment_CheckedChanged;
            // 
            // rdoFutureValue
            // 
            rdoFutureValue.Checked = true;
            rdoFutureValue.Location = new System.Drawing.Point(19, 28);
            rdoFutureValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoFutureValue.Name = "rdoFutureValue";
            rdoFutureValue.Size = new System.Drawing.Size(110, 24);
            rdoFutureValue.TabIndex = 0;
            rdoFutureValue.TabStop = true;
            rdoFutureValue.Text = "Future value";
            rdoFutureValue.CheckedChanged += rdoFutureValue_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(230, 201);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(88, 27);
            btnExit.TabIndex = 16;
            btnExit.Text = "E&xit";
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(125, 201);
            btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(88, 27);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "&Calculate";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtYears
            // 
            txtYears.Location = new System.Drawing.Point(167, 136);
            txtYears.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtYears.Name = "txtYears";
            txtYears.Size = new System.Drawing.Size(131, 23);
            txtYears.TabIndex = 12;
            txtYears.TextChanged += txtYears_TextChanged;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new System.Drawing.Point(167, 108);
            txtInterestRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new System.Drawing.Size(131, 23);
            txtInterestRate.TabIndex = 9;
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new System.Drawing.Point(167, 81);
            txtMonthlyInvestment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new System.Drawing.Size(131, 23);
            txtMonthlyInvestment.TabIndex = 7;
            // 
            // txtFutureValue
            // 
            txtFutureValue.BackColor = System.Drawing.SystemColors.Window;
            txtFutureValue.Location = new System.Drawing.Point(167, 164);
            txtFutureValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new System.Drawing.Size(131, 23);
            txtFutureValue.TabIndex = 14;
            txtFutureValue.TabStop = false;
            txtFutureValue.TextChanged += txtFutureValue_TextChanged;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(27, 164);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 23);
            label4.TabIndex = 13;
            label4.Text = "Future value:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(27, 136);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 23);
            label3.TabIndex = 11;
            label3.Text = "Number of years:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(27, 108);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 23);
            label2.TabIndex = 10;
            label2.Text = "Yearly interest rate:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(27, 81);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 23);
            label1.TabIndex = 8;
            label1.Text = "Monthly investment:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInvestment
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(342, 241);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtYears);
            Controls.Add(txtInterestRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(txtFutureValue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmInvestment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Calculate Investment";
            Load += frmInvestment_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoMonthlyInvestment;
        private System.Windows.Forms.RadioButton rdoFutureValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}