using System;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal housePrice = decimal.Parse(txtHousePrice.Text);
                decimal downPaymentPercent = decimal.Parse(txtDownPayment.Text);
                decimal annualRate = decimal.Parse(txtInterestRate.Text) / 100m;
                int loanYears = int.Parse(txtLoanTerm.Text);
                int graceYears = int.Parse(txtGracePeriod.Text);

                if (housePrice <= 0 || downPaymentPercent < 0 || downPaymentPercent >= 100 ||
                    annualRate < 0 || loanYears <= 0 || graceYears < 0 || graceYears >= loanYears)
                {
                    MessageBox.Show("請確認輸入值是否合理。");
                    return;
                }

                decimal downPayment = housePrice * downPaymentPercent / 100m;
                decimal loanAmount = housePrice - downPayment;

                decimal monthlyRate = annualRate / 12m;
                int totalMonths = loanYears * 12;
                int graceMonths = graceYears * 12;
                int repayMonths = totalMonths - graceMonths;

                decimal monthlyPayment;
                if (monthlyRate == 0)
                {
                    monthlyPayment = loanAmount / repayMonths;
                }
                else
                {
                    double r = (double)monthlyRate;
                    double n = repayMonths;
                    double p = (double)loanAmount;
                    monthlyPayment = (decimal)(p * r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1));
                }

                decimal firstInterest = loanAmount * monthlyRate;
                decimal firstPrincipal = graceMonths > 0 ? 0 : monthlyPayment - firstInterest;

                decimal totalInterest;
                if (graceMonths > 0)
                {
                    decimal graceInterest = firstInterest * graceMonths;
                    decimal repayInterest = monthlyPayment * repayMonths - loanAmount;
                    totalInterest = graceInterest + repayInterest;
                }
                else
                {
                    totalInterest = monthlyPayment * totalMonths - loanAmount;
                }

                decimal totalPayment = loanAmount + totalInterest;

                lblLoanAmountValue.Text = loanAmount.ToString("N2");
                lblMonthlyPaymentValue.Text = monthlyPayment.ToString("N2");
                lblFirstInterestValue.Text = firstInterest.ToString("N2");
                lblFirstPrincipalValue.Text = firstPrincipal.ToString("N2");
                lblTotalInterestValue.Text = totalInterest.ToString("N2");
                lblTotalPaymentValue.Text = totalPayment.ToString("N2");
            }
            catch
            {
                MessageBox.Show("輸入格式錯誤，請輸入數字。");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHousePrice.Text = "10000000";
            txtDownPayment.Text = "20";
            txtInterestRate.Text = "2.15";
            txtLoanTerm.Text = "20";
            txtGracePeriod.Text = "0";

            lblLoanAmountValue.Text = "-";
            lblMonthlyPaymentValue.Text = "-";
            lblFirstInterestValue.Text = "-";
            lblFirstPrincipalValue.Text = "-";
            lblTotalInterestValue.Text = "-";
            lblTotalPaymentValue.Text = "-";
        }
    }
}