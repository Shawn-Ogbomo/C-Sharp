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
                decimal futureValue = 0;

                bool txtInterestRateEmpty = String.IsNullOrEmpty(txtInterestRate.Text);
                bool txtYearsEmpty = String.IsNullOrEmpty(txtYears.Text);

                if (txtInterestRateEmpty && txtYearsEmpty)
                {
                    futureValue = CalculateFutureValue(monthlyInvestment);
                    txtInterestRate.Text = "0.05";
                    txtYears.Text = "12";
                }
                else if (!txtInterestRateEmpty && txtYearsEmpty)
                {
                    futureValue = CalculateFutureValue(monthlyInvestment, YearInterestToMonth(Convert.ToDecimal(txtInterestRate.Text)));
                    txtYears.Text = "12";
                }
                else if (txtInterestRateEmpty && !txtYearsEmpty)
                {
                    futureValue = CalculateFutureValue(monthlyInvestment, months: YearToMon(Convert.ToInt32(txtYears.Text)));
                    txtInterestRate.Text = "0.05";
                }
                else
                {
                    futureValue = CalculateFutureValue(monthlyInvestment, YearInterestToMonth(Convert.ToDecimal(txtInterestRate.Text)), YearToMon(Convert.ToInt32(txtYears.Text)));
                }

                txtFutureValue.Text = futureValue.ToString("c");
                txtError.Hide();
                txtMonthlyInvestment.Focus();
            }
            catch (System.FormatException internal_e)
            {
                txtError.Text = internal_e.Message;
                txtError.Show();
            }
            catch (OverflowException internal_e)
            {
                txtError.Text = internal_e.Message;
                txtError.Show();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
            txtInterestRate.Text = "";
            txtMonthlyInvestment.Text = "";
            txtYears.Text = "";
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate = 0.05m, int months = 12)
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

        private decimal YearInterestToMonth(decimal interestRate)
        {
            return Convert.ToDecimal(interestRate) / 12 / 100;
        }

        private int YearToMon(int numYears)
        {
            return numYears * 12;
        }
    }
}