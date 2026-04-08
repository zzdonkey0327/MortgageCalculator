using System;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.Resize += Form1_Resize;

            rbDownPercent.CheckedChanged += DownPaymentModeChanged;
            rbDownAmount.CheckedChanged += DownPaymentModeChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterMainPanel();
            UpdateDownPaymentModeUI();
            ResetResultLabels();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterMainPanel();
        }

        private void CenterMainPanel()
        {
            if (mainPanel == null) return;

            mainPanel.Left = Math.Max(20, (this.ClientSize.Width - mainPanel.Width) / 2);
            mainPanel.Top = 24;
        }

        private void DownPaymentModeChanged(object sender, EventArgs e)
        {
            UpdateDownPaymentModeUI();
        }

        private void UpdateDownPaymentModeUI()
        {
            bool usePercent = rbDownPercent.Checked;

            nudDownPercent.Visible = usePercent;
            lblDownPercentUnit.Visible = usePercent;
            lblDownPercentHint.Visible = usePercent;

            nudDownAmount.Visible = !usePercent;
            lblDownAmountUnit.Visible = !usePercent;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal housePrice = nudHousePrice.Value;

                if (housePrice <= 0)
                {
                    MessageBox.Show("房屋總價必須大於 0。", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal downPayment = rbDownPercent.Checked
                    ? housePrice * nudDownPercent.Value / 100m
                    : nudDownAmount.Value;

                if (downPayment < 0 || downPayment >= housePrice)
                {
                    MessageBox.Show("請確認自備款金額或比例是否合理。", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal loanAmount = housePrice - downPayment;
                decimal annualRate = nudInterestRate.Value / 100m;
                int loanYears = (int)nudLoanTerm.Value;
                int graceYears = (int)nudGracePeriod.Value;

                if (loanYears <= 0)
                {
                    MessageBox.Show("貸款年限必須大於 0。", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (graceYears < 0 || graceYears >= loanYears)
                {
                    MessageBox.Show("寬限期不得小於 0 或大於等於貸款年限。", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                    double mr = (double)monthlyRate;
                    double n = repayMonths;
                    double pv = (double)loanAmount;

                    monthlyPayment = (decimal)(
                        pv * mr * Math.Pow(1 + mr, n) /
                        (Math.Pow(1 + mr, n) - 1)
                    );
                }

                decimal firstInterest = loanAmount * monthlyRate;
                decimal firstPrincipal;
                decimal totalInterest;

                if (graceMonths > 0)
                {
                    firstPrincipal = 0m;
                    decimal graceInterest = firstInterest * graceMonths;
                    decimal repayInterest = monthlyPayment * repayMonths - loanAmount;
                    totalInterest = graceInterest + repayInterest;
                }
                else
                {
                    firstPrincipal = monthlyPayment - firstInterest;
                    totalInterest = monthlyPayment * totalMonths - loanAmount;
                }

                decimal totalPayment = loanAmount + totalInterest;

                lblLoanAmountValue.Text = "NT$ " + loanAmount.ToString("N2");
                lblMonthlyPaymentValue.Text = "NT$ " + monthlyPayment.ToString("N2");
                lblGraceMonthlyValue.Text = graceMonths > 0
                    ? "NT$ " + firstInterest.ToString("N2")
                    : "—";
                lblFirstInterestValue.Text = "NT$ " + firstInterest.ToString("N2");
                lblFirstPrincipalValue.Text = graceMonths > 0
                    ? "NT$ 0.00（寬限中）"
                    : "NT$ " + firstPrincipal.ToString("N2");
                lblTotalInterestValue.Text = "NT$ " + totalInterest.ToString("N2");
                lblTotalPaymentValue.Text = "NT$ " + totalPayment.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("計算發生錯誤：" + ex.Message, "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudHousePrice.Value = 10000000;
            rbDownPercent.Checked = true;
            nudDownPercent.Value = 20;
            nudDownAmount.Value = 2000000;
            nudInterestRate.Value = 2.15m;
            nudLoanTerm.Value = 20;
            nudGracePeriod.Value = 0;

            UpdateDownPaymentModeUI();
            ResetResultLabels();
        }

        private void ResetResultLabels()
        {
            lblLoanAmountValue.Text = "-";
            lblMonthlyPaymentValue.Text = "-";
            lblGraceMonthlyValue.Text = "-";
            lblFirstInterestValue.Text = "-";
            lblFirstPrincipalValue.Text = "-";
            lblTotalInterestValue.Text = "-";
            lblTotalPaymentValue.Text = "-";
        }
    }
}