using System;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, System.EventArgs e)
        {
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                decimal interestRate = (Convert.ToDecimal(txtInterestRate.Text) / 12) / 100;
                int years = Convert.ToInt32(txtYears.Text) * 12;

                decimal futureValue = CalculateFutureValue(monthlyInvestment, interestRate, years);
                txtFutureValue.Text = futureValue.ToString("c");
                txtError.Visible = false;
                txtMonthlyInvestment.Focus();
            }
            catch (System.FormatException internal_e)
            {
                txtError.Visible = true;
                txtError.Text = internal_e.Message;
            }
            catch (OverflowException internal_e)
            {
                txtError.Visible = true;
                txtError.Text = internal_e.Message;
            }
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            if (monthlyInvestment < 0 || monthlyInterestRate < 0 || months < 0)
            {
                throw new FormatException("No negative values...");
            }

            decimal futureValue = 0;

            for (int i = 0; i < months; ++i)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }
    }
}