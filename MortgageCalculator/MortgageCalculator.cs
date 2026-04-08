using System;
using System.Drawing;
using System.Windows.Forms;

namespace MortgageCalculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        // --- 輸入控制項 ---
        private NumericUpDown nudHousePrice;
        private RadioButton rbDownPercent, rbDownAmount;
        private NumericUpDown nudDownPercent, nudDownAmount;
        private NumericUpDown nudInterestRate;
        private NumericUpDown nudLoanTerm;
        private NumericUpDown nudGracePeriod;
        private Button btnCalculate, btnReset;

        // --- 結果標籤 ---
        private Label lblLoanAmountVal;
        private Label lblMonthlyPaymentVal;
        private Label lblFirstInterestVal;
        private Label lblFirstPrincipalVal;
        private Label lblTotalInterestVal;
        private Label lblTotalPaymentVal;

        private Panel panelResult;

        public MainForm()
        {
            InitUI();
        }

        private void InitUI()
        {
            this.Text = "個人房貸試算器 — Mortgage Calculator";
            this.Size = new Size(780, 480);
            this.MinimumSize = new Size(780, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Microsoft JhengHei UI", 10f);

            // === 標題 ===
            var lblTitle = new Label
            {
                Text = "🏠 個人房貸試算器",
                Font = new Font("Microsoft JhengHei UI", 16f, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 78, 121),
                AutoSize = true,
                Location = new Point(20, 16)
            };
            this.Controls.Add(lblTitle);

            var sep = new Panel
            {
                Location = new Point(20, 52),
                Size = new Size(724, 2),
                BackColor = Color.FromArgb(31, 78, 121)
            };
            this.Controls.Add(sep);

            // === 輸入面板 ===
            var panInput = new Panel
            {
                Location = new Point(20, 64),
                Size = new Size(724, 340),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            panInput.Paint += (s, e) => DrawPanelTitle(e.Graphics, "輸入資訊", panInput.Width);
            this.Controls.Add(panInput);

            int col1 = 20, col2 = 400;
            int row = 36;

            // 房屋總價
            panInput.Controls.Add(MakeLabel("房屋總價（新台幣）：", col1, row));
            nudHousePrice = new NumericUpDown
            {
                Location = new Point(col1, row + 24),
                Size = new Size(210, 28),
                Minimum = 0,
                Maximum = 1000000000,
                Value = 10000000,
                Increment = 100000,
                ThousandsSeparator = true,
                DecimalPlaces = 0
            };
            panInput.Controls.Add(nudHousePrice);
            panInput.Controls.Add(MakeHint("元", col1 + 216, row + 28));

            // 自備款
            row += 68;
            panInput.Controls.Add(MakeLabel("自備款方式：", col1, row));
            rbDownPercent = new RadioButton { Text = "比例 (%)", Location = new Point(col1, row + 24), AutoSize = true, Checked = true };
            rbDownAmount = new RadioButton { Text = "金額 (元)", Location = new Point(col1 + 110, row + 24), AutoSize = true };
            panInput.Controls.Add(rbDownPercent);
            panInput.Controls.Add(rbDownAmount);

            nudDownPercent = new NumericUpDown
            {
                Location = new Point(col1, row + 52),
                Size = new Size(120, 28),
                Minimum = 0,
                Maximum = 100,
                Value = 20,
                DecimalPlaces = 1,
                Increment = 1
            };
            nudDownAmount = new NumericUpDown
            {
                Location = new Point(col1, row + 52),
                Size = new Size(180, 28),
                Minimum = 0,
                Maximum = 1000000000,
                Value = 2000000,
                Increment = 100000,
                ThousandsSeparator = true,
                Visible = false
            };
            panInput.Controls.Add(nudDownPercent);
            panInput.Controls.Add(nudDownAmount);
            panInput.Controls.Add(MakeHint("預設 20%", col1 + 126, row + 56));

            rbDownPercent.CheckedChanged += (s, e) =>
            {
                nudDownPercent.Visible = rbDownPercent.Checked;
                nudDownAmount.Visible = !rbDownPercent.Checked;
            };

            // 貸款利率（右欄）
            panInput.Controls.Add(MakeLabel("貸款年利率：", col2, 36));
            nudInterestRate = new NumericUpDown
            {
                Location = new Point(col2, 60),
                Size = new Size(120, 28),
                Minimum = 0,
                Maximum = 30,
                Value = 2.15m,
                DecimalPlaces = 2,
                Increment = 0.01m
            };
            panInput.Controls.Add(nudInterestRate);
            panInput.Controls.Add(MakeHint("% / 年", col2 + 126, 64));

            // 貸款年限
            panInput.Controls.Add(MakeLabel("貸款年限：", col2, 106));
            nudLoanTerm = new NumericUpDown
            {
                Location = new Point(col2, 130),
                Size = new Size(100, 28),
                Minimum = 1,
                Maximum = 40,
                Value = 20
            };
            panInput.Controls.Add(nudLoanTerm);
            panInput.Controls.Add(MakeHint("年", col2 + 106, 134));

            // 寬限期
            panInput.Controls.Add(MakeLabel("寬限期（選填）：", col2, 174));
            nudGracePeriod = new NumericUpDown
            {
                Location = new Point(col2, 198),
                Size = new Size(100, 28),
                Minimum = 0,
                Maximum = 10,
                Value = 0
            };
            panInput.Controls.Add(nudGracePeriod);
            panInput.Controls.Add(MakeHint("年（前幾年只繳利息）", col2 + 106, 202));

            // 按鈕
            btnCalculate = new Button
            {
                Text = "▶ 開始試算",
                Location = new Point(col1, 298),
                Size = new Size(140, 38),
                BackColor = Color.FromArgb(31, 78, 121),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft JhengHei UI", 10f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.Click += BtnCalculate_Click;
            panInput.Controls.Add(btnCalculate);

            btnReset = new Button
            {
                Text = "重置",
                Location = new Point(col1 + 150, 298),
                Size = new Size(80, 38),
                BackColor = Color.FromArgb(200, 210, 220),
                ForeColor = Color.FromArgb(50, 50, 80),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Click += BtnReset_Click;
            panInput.Controls.Add(btnReset);

            // === 結果面板 ===
            panelResult = new Panel
            {
                Location = new Point(20, 418),
                Size = new Size(724, 210),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };
            panelResult.Paint += (s, e) => DrawPanelTitle(e.Graphics, "試算結果", panelResult.Width);
            this.Controls.Add(panelResult);

            int rc1 = 20, rc2 = 210, rc3 = 420, rc4 = 600;
            int rr = 40;

            panelResult.Controls.Add(MakeResultLabel("貸款總金額：", rc1, rr));
            lblLoanAmountVal = MakeResultValue("—", rc2, rr);
            panelResult.Controls.Add(lblLoanAmountVal);

            panelResult.Controls.Add(MakeResultLabel("每月應繳（本＋息）：", rc3, rr));
            lblMonthlyPaymentVal = MakeResultValue("—", rc4, rr);
            panelResult.Controls.Add(lblMonthlyPaymentVal);

            rr += 46;
            panelResult.Controls.Add(MakeResultLabel("首期利息：", rc1, rr));
            lblFirstInterestVal = MakeResultValue("—", rc2, rr);
            panelResult.Controls.Add(lblFirstInterestVal);

            panelResult.Controls.Add(MakeResultLabel("首期本金：", rc3, rr));
            lblFirstPrincipalVal = MakeResultValue("—", rc4, rr);
            panelResult.Controls.Add(lblFirstPrincipalVal);

            rr += 46;
            panelResult.Controls.Add(MakeResultLabel("總利息支出：", rc1, rr));
            lblTotalInterestVal = MakeResultValue("—", rc2, rr);
            panelResult.Controls.Add(lblTotalInterestVal);

            panelResult.Controls.Add(MakeResultLabel("總還款金額：", rc3, rr));
            lblTotalPaymentVal = MakeResultValue("—", rc4, rr);
            panelResult.Controls.Add(lblTotalPaymentVal);

            panelResult.Controls.Add(new Label
            {
                Text = "※ 採等額本息還款計算（寬限期內僅繳利息）",
                Location = new Point(20, 162),
                AutoSize = true,
                ForeColor = Color.Gray,
                Font = new Font("Microsoft JhengHei UI", 8.5f)
            });
        }

        // ===== Helper Methods =====

        private Label MakeLabel(string text, int x, int y) => new Label
        {
            Text = text,
            Location = new Point(x, y),
            AutoSize = true,
            ForeColor = Color.FromArgb(60, 80, 100),
            Font = new Font("Microsoft JhengHei UI", 9.5f, FontStyle.Bold)
        };

        private Label MakeHint(string text, int x, int y) => new Label
        {
            Text = text,
            Location = new Point(x, y),
            AutoSize = true,
            ForeColor = Color.Gray,
            Font = new Font("Microsoft JhengHei UI", 9f)
        };

        private Label MakeResultLabel(string text, int x, int y) => new Label
        {
            Text = text,
            Location = new Point(x, y),
            AutoSize = true,
            ForeColor = Color.FromArgb(80, 100, 120),
            Font = new Font("Microsoft JhengHei UI", 9.5f)
        };

        private Label MakeResultValue(string text, int x, int y) => new Label
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(180, 26),
            ForeColor = Color.FromArgb(31, 78, 121),
            Font = new Font("Microsoft JhengHei UI", 10f, FontStyle.Bold)
        };

        private void DrawPanelTitle(Graphics g, string title, int width)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(31, 78, 121)), 0, 0, width, 28);
            g.DrawString(title, new Font("Microsoft JhengHei UI", 10f, FontStyle.Bold),
                Brushes.White, 12, 5);
        }

        // ===== 計算邏輯 =====

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal housePrice = nudHousePrice.Value;

                decimal downPayment = rbDownPercent.Checked
                    ? housePrice * nudDownPercent.Value / 100m
                    : nudDownAmount.Value;

                if (downPayment >= housePrice)
                {
                    MessageBox.Show("自備款不得大於或等於房屋總價。", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal loanAmount = housePrice - downPayment;
                decimal annualRate = nudInterestRate.Value / 100m;
                int loanTermYears = (int)nudLoanTerm.Value;
                int gracePeriodYears = (int)nudGracePeriod.Value;

                if (gracePeriodYears >= loanTermYears)
                {
                    MessageBox.Show("寬限期不得大於或等於貸款年限。", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal monthlyRate = annualRate / 12m;
                int totalMonths = loanTermYears * 12;
                int graceMonths = gracePeriodYears * 12;
                int repayMonths = totalMonths - graceMonths;

                // 等額本息月付金公式: M = P * r(1+r)^n / [(1+r)^n - 1]
                decimal monthlyPayment;
                if (monthlyRate == 0)
                    monthlyPayment = loanAmount / repayMonths;
                else
                {
                    double mr = (double)monthlyRate;
                    double n = repayMonths;
                    double pv = (double)loanAmount;
                    monthlyPayment = (decimal)(pv * mr * Math.Pow(1 + mr, n)
                                              / (Math.Pow(1 + mr, n) - 1));
                }

                decimal firstInterest = loanAmount * monthlyRate;
                decimal firstPrincipal = graceMonths > 0 ? 0 : monthlyPayment - firstInterest;

                decimal totalInterest;
                if (graceMonths > 0)
                {
                    decimal graceTotal = firstInterest * graceMonths;
                    decimal repayTotal = (monthlyPayment * repayMonths) - loanAmount;
                    totalInterest = graceTotal + repayTotal;
                }
                else
                {
                    totalInterest = (monthlyPayment * totalMonths) - loanAmount;
                }

                decimal totalPayment = loanAmount + totalInterest;

                // 顯示結果
                lblLoanAmountVal.Text = "NT$ " + Fmt(loanAmount);
                lblMonthlyPaymentVal.Text = graceMonths > 0
                    ? $"NT$ {Fmt(monthlyPayment)}\n(寬限 NT$ {Fmt(firstInterest)})"
                    : "NT$ " + Fmt(monthlyPayment);
                lblFirstInterestVal.Text = "NT$ " + Fmt(firstInterest);
                lblFirstPrincipalVal.Text = graceMonths > 0
                    ? "NT$ 0.00（寬限中）"
                    : "NT$ " + Fmt(firstPrincipal);
                lblTotalInterestVal.Text = "NT$ " + Fmt(totalInterest);
                lblTotalPaymentVal.Text = "NT$ " + Fmt(totalPayment);

                panelResult.Visible = true;
                this.Height = 680;
            }
            catch (Exception ex)
            {
                MessageBox.Show("計算錯誤：" + ex.Message, "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            nudHousePrice.Value = 10000000;
            rbDownPercent.Checked = true;
            nudDownPercent.Value = 20;
            nudDownAmount.Value = 2000000;
            nudInterestRate.Value = 2.15m;
            nudLoanTerm.Value = 20;
            nudGracePeriod.Value = 0;
            panelResult.Visible = false;
            this.Height = 480;
        }

        private string Fmt(decimal value) => value.ToString("N2");
    }
}