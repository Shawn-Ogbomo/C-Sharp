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
                var monthlyInvestment = Convert.ToDouble(txtMonthlyInvestment.Text);
                var interestRate = (Convert.ToDouble(txtInterestRate.Text) / 12) / 100;
                var years = Convert.ToInt32(txtYears.Text) * 12;

                if (monthlyInvestment < 0 || interestRate < 0 || years < 0)
                {
                    throw new FormatException("No negative values...");
                }

                var futureValue = 0d;

                for (var i = 0; i < years; ++i)
                {
                    futureValue = (futureValue + monthlyInvestment) * (1 + interestRate);
                }

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
    }
}