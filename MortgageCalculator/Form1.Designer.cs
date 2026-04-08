namespace MortgageCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel resultPanel;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblDownPaymentMode;
        private System.Windows.Forms.RadioButton rbDownPercent;
        private System.Windows.Forms.RadioButton rbDownAmount;
        private System.Windows.Forms.NumericUpDown nudHousePrice;
        private System.Windows.Forms.NumericUpDown nudDownPercent;
        private System.Windows.Forms.NumericUpDown nudDownAmount;
        private System.Windows.Forms.NumericUpDown nudInterestRate;
        private System.Windows.Forms.NumericUpDown nudLoanTerm;
        private System.Windows.Forms.NumericUpDown nudGracePeriod;

        private System.Windows.Forms.Label lblHousePriceUnit;
        private System.Windows.Forms.Label lblDownPercentUnit;
        private System.Windows.Forms.Label lblDownAmountUnit;
        private System.Windows.Forms.Label lblDownPercentHint;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblInterestRateUnit;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label lblLoanTermUnit;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.Label lblGracePeriodUnit;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblGraceMonthly;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalPayment;

        private System.Windows.Forms.Label lblLoanAmountValue;
        private System.Windows.Forms.Label lblMonthlyPaymentValue;
        private System.Windows.Forms.Label lblGraceMonthlyValue;
        private System.Windows.Forms.Label lblFirstInterestValue;
        private System.Windows.Forms.Label lblFirstPrincipalValue;
        private System.Windows.Forms.Label lblTotalInterestValue;
        private System.Windows.Forms.Label lblTotalPaymentValue;
        private System.Windows.Forms.Label lblNote;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.nudHousePrice = new System.Windows.Forms.NumericUpDown();
            this.lblHousePriceUnit = new System.Windows.Forms.Label();
            this.lblDownPaymentMode = new System.Windows.Forms.Label();
            this.rbDownPercent = new System.Windows.Forms.RadioButton();
            this.rbDownAmount = new System.Windows.Forms.RadioButton();
            this.nudDownPercent = new System.Windows.Forms.NumericUpDown();
            this.nudDownAmount = new System.Windows.Forms.NumericUpDown();
            this.lblDownPercentUnit = new System.Windows.Forms.Label();
            this.lblDownAmountUnit = new System.Windows.Forms.Label();
            this.lblDownPercentHint = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.nudInterestRate = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRateUnit = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.nudLoanTerm = new System.Windows.Forms.NumericUpDown();
            this.lblLoanTermUnit = new System.Windows.Forms.Label();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.nudGracePeriod = new System.Windows.Forms.NumericUpDown();
            this.lblGracePeriodUnit = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblGraceMonthly = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblLoanAmountValue = new System.Windows.Forms.Label();
            this.lblMonthlyPaymentValue = new System.Windows.Forms.Label();
            this.lblGraceMonthlyValue = new System.Windows.Forms.Label();
            this.lblFirstInterestValue = new System.Windows.Forms.Label();
            this.lblFirstPrincipalValue = new System.Windows.Forms.Label();
            this.lblTotalInterestValue = new System.Windows.Forms.Label();
            this.lblTotalPaymentValue = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHousePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGracePeriod)).BeginInit();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";
            this.Controls.Add(this.mainPanel);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.inputPanel);
            this.mainPanel.Controls.Add(this.resultPanel);
            this.mainPanel.Location = new System.Drawing.Point(150, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 650);
            this.mainPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 88);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(32, 52, 84);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "個人房貸試算器";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(110, 122, 138);
            this.lblSubtitle.Location = new System.Drawing.Point(27, 57);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(351, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "請輸入房貸條件，系統將依等額本息方式進行試算";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.lblHousePrice);
            this.inputPanel.Controls.Add(this.nudHousePrice);
            this.inputPanel.Controls.Add(this.lblHousePriceUnit);
            this.inputPanel.Controls.Add(this.lblDownPaymentMode);
            this.inputPanel.Controls.Add(this.rbDownPercent);
            this.inputPanel.Controls.Add(this.rbDownAmount);
            this.inputPanel.Controls.Add(this.nudDownPercent);
            this.inputPanel.Controls.Add(this.nudDownAmount);
            this.inputPanel.Controls.Add(this.lblDownPercentUnit);
            this.inputPanel.Controls.Add(this.lblDownAmountUnit);
            this.inputPanel.Controls.Add(this.lblDownPercentHint);
            this.inputPanel.Controls.Add(this.lblInterestRate);
            this.inputPanel.Controls.Add(this.nudInterestRate);
            this.inputPanel.Controls.Add(this.lblInterestRateUnit);
            this.inputPanel.Controls.Add(this.lblLoanTerm);
            this.inputPanel.Controls.Add(this.nudLoanTerm);
            this.inputPanel.Controls.Add(this.lblLoanTermUnit);
            this.inputPanel.Controls.Add(this.lblGracePeriod);
            this.inputPanel.Controls.Add(this.nudGracePeriod);
            this.inputPanel.Controls.Add(this.lblGracePeriodUnit);
            this.inputPanel.Controls.Add(this.btnCalculate);
            this.inputPanel.Controls.Add(this.btnReset);
            this.inputPanel.Location = new System.Drawing.Point(0, 106);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(800, 270);
            this.inputPanel.TabIndex = 1;
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblHousePrice.Location = new System.Drawing.Point(30, 28);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(162, 22);
            this.lblHousePrice.TabIndex = 0;
            this.lblHousePrice.Text = "房屋總價（新台幣）：";
            // 
            // nudHousePrice
            // 
            this.nudHousePrice.Location = new System.Drawing.Point(30, 54);
            this.nudHousePrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudHousePrice.Name = "nudHousePrice";
            this.nudHousePrice.Size = new System.Drawing.Size(220, 29);
            this.nudHousePrice.TabIndex = 1;
            this.nudHousePrice.ThousandsSeparator = true;
            this.nudHousePrice.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudHousePrice.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // lblHousePriceUnit
            // 
            this.lblHousePriceUnit.AutoSize = true;
            this.lblHousePriceUnit.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblHousePriceUnit.Location = new System.Drawing.Point(258, 58);
            this.lblHousePriceUnit.Name = "lblHousePriceUnit";
            this.lblHousePriceUnit.Size = new System.Drawing.Size(30, 22);
            this.lblHousePriceUnit.TabIndex = 2;
            this.lblHousePriceUnit.Text = "元";
            // 
            // lblDownPaymentMode
            // 
            this.lblDownPaymentMode.AutoSize = true;
            this.lblDownPaymentMode.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblDownPaymentMode.Location = new System.Drawing.Point(30, 102);
            this.lblDownPaymentMode.Name = "lblDownPaymentMode";
            this.lblDownPaymentMode.Size = new System.Drawing.Size(102, 22);
            this.lblDownPaymentMode.TabIndex = 3;
            this.lblDownPaymentMode.Text = "自備款方式：";
            // 
            // rbDownPercent
            // 
            this.rbDownPercent.AutoSize = true;
            this.rbDownPercent.Checked = true;
            this.rbDownPercent.Location = new System.Drawing.Point(30, 128);
            this.rbDownPercent.Name = "rbDownPercent";
            this.rbDownPercent.Size = new System.Drawing.Size(94, 26);
            this.rbDownPercent.TabIndex = 4;
            this.rbDownPercent.TabStop = true;
            this.rbDownPercent.Text = "比例 (%)";
            this.rbDownPercent.UseVisualStyleBackColor = true;
            // 
            // rbDownAmount
            // 
            this.rbDownAmount.AutoSize = true;
            this.rbDownAmount.Location = new System.Drawing.Point(140, 128);
            this.rbDownAmount.Name = "rbDownAmount";
            this.rbDownAmount.Size = new System.Drawing.Size(94, 26);
            this.rbDownAmount.TabIndex = 5;
            this.rbDownAmount.Text = "金額 (元)";
            this.rbDownAmount.UseVisualStyleBackColor = true;
            // 
            // nudDownPercent
            // 
            this.nudDownPercent.DecimalPlaces = 1;
            this.nudDownPercent.Location = new System.Drawing.Point(30, 156);
            this.nudDownPercent.Name = "nudDownPercent";
            this.nudDownPercent.Size = new System.Drawing.Size(120, 29);
            this.nudDownPercent.TabIndex = 6;
            this.nudDownPercent.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // nudDownAmount
            // 
            this.nudDownAmount.Location = new System.Drawing.Point(30, 156);
            this.nudDownAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudDownAmount.Name = "nudDownAmount";
            this.nudDownAmount.Size = new System.Drawing.Size(220, 29);
            this.nudDownAmount.TabIndex = 7;
            this.nudDownAmount.ThousandsSeparator = true;
            this.nudDownAmount.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudDownAmount.Value = new decimal(new int[] { 2000000, 0, 0, 0 });
            this.nudDownAmount.Visible = false;
            // 
            // lblDownPercentUnit
            // 
            this.lblDownPercentUnit.AutoSize = true;
            this.lblDownPercentUnit.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblDownPercentUnit.Location = new System.Drawing.Point(158, 160);
            this.lblDownPercentUnit.Name = "lblDownPercentUnit";
            this.lblDownPercentUnit.Size = new System.Drawing.Size(25, 22);
            this.lblDownPercentUnit.TabIndex = 8;
            this.lblDownPercentUnit.Text = "%";
            // 
            // lblDownAmountUnit
            // 
            this.lblDownAmountUnit.AutoSize = true;
            this.lblDownAmountUnit.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblDownAmountUnit.Location = new System.Drawing.Point(258, 160);
            this.lblDownAmountUnit.Name = "lblDownAmountUnit";
            this.lblDownAmountUnit.Size = new System.Drawing.Size(30, 22);
            this.lblDownAmountUnit.TabIndex = 9;
            this.lblDownAmountUnit.Text = "元";
            this.lblDownAmountUnit.Visible = false;
            // 
            // lblDownPercentHint
            // 
            this.lblDownPercentHint.AutoSize = true;
            this.lblDownPercentHint.ForeColor = System.Drawing.Color.Gray;
            this.lblDownPercentHint.Location = new System.Drawing.Point(190, 160);
            this.lblDownPercentHint.Name = "lblDownPercentHint";
            this.lblDownPercentHint.Size = new System.Drawing.Size(71, 22);
            this.lblDownPercentHint.TabIndex = 10;
            this.lblDownPercentHint.Text = "預設 20%";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblInterestRate.Location = new System.Drawing.Point(430, 28);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(102, 22);
            this.lblInterestRate.TabIndex = 11;
            this.lblInterestRate.Text = "貸款年利率：";
            // 
            // nudInterestRate
            // 
            this.nudInterestRate.DecimalPlaces = 2;
            this.nudInterestRate.Location = new System.Drawing.Point(430, 54);
            this.nudInterestRate.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudInterestRate.Name = "nudInterestRate";
            this.nudInterestRate.Size = new System.Drawing.Size(120, 29);
            this.nudInterestRate.TabIndex = 12;
            this.nudInterestRate.Value = new decimal(new int[] { 215, 0, 0, 131072 });
            this.nudInterestRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // lblInterestRateUnit
            // 
            this.lblInterestRateUnit.AutoSize = true;
            this.lblInterestRateUnit.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblInterestRateUnit.Location = new System.Drawing.Point(556, 58);
            this.lblInterestRateUnit.Name = "lblInterestRateUnit";
            this.lblInterestRateUnit.Size = new System.Drawing.Size(49, 22);
            this.lblInterestRateUnit.TabIndex = 13;
            this.lblInterestRateUnit.Text = "% / 年";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblLoanTerm.Location = new System.Drawing.Point(430, 102);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(82, 22);
            this.lblLoanTerm.TabIndex = 14;
            this.lblLoanTerm.Text = "貸款年限：";
            // 
            // nudLoanTerm
            // 
            this.nudLoanTerm.Location = new System.Drawing.Point(430, 128);
            this.nudLoanTerm.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            this.nudLoanTerm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudLoanTerm.Name = "nudLoanTerm";
            this.nudLoanTerm.Size = new System.Drawing.Size(100, 29);
            this.nudLoanTerm.TabIndex = 15;
            this.nudLoanTerm.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblLoanTermUnit
            // 
            this.lblLoanTermUnit.AutoSize = true;
            this.lblLoanTermUnit.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblLoanTermUnit.Location = new System.Drawing.Point(536, 132);
            this.lblLoanTermUnit.Name = "lblLoanTermUnit";
            this.lblLoanTermUnit.Size = new System.Drawing.Size(30, 22);
            this.lblLoanTermUnit.TabIndex = 16;
            this.lblLoanTermUnit.Text = "年";
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblGracePeriod.Location = new System.Drawing.Point(430, 176);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(122, 22);
            this.lblGracePeriod.TabIndex = 17;
            this.lblGracePeriod.Text = "寬限期（選填）：";
            // 
            // nudGracePeriod
            // 
            this.nudGracePeriod.Location = new System.Drawing.Point(430, 202);
            this.nudGracePeriod.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudGracePeriod.Name = "nudGracePeriod";
            this.nudGracePeriod.Size = new System.Drawing.Size(100, 29);
            this.nudGracePeriod.TabIndex = 18;
            // 
            // lblGracePeriodUnit
            // 
            this.lblGracePeriodUnit.AutoSize = true;
            this.lblGracePeriodUnit.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblGracePeriodUnit.Location = new System.Drawing.Point(536, 206);
            this.lblGracePeriodUnit.Name = "lblGracePeriodUnit";
            this.lblGracePeriodUnit.Size = new System.Drawing.Size(152, 22);
            this.lblGracePeriodUnit.TabIndex = 19;
            this.lblGracePeriodUnit.Text = "年（前幾年只繳利息）";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(30, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 38);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "開始試算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnReset.Location = new System.Drawing.Point(186, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 38);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.White;
            this.resultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPanel.Controls.Add(this.lblResultTitle);
            this.resultPanel.Controls.Add(this.lblLoanAmount);
            this.resultPanel.Controls.Add(this.lblMonthlyPayment);
            this.resultPanel.Controls.Add(this.lblGraceMonthly);
            this.resultPanel.Controls.Add(this.lblFirstInterest);
            this.resultPanel.Controls.Add(this.lblFirstPrincipal);
            this.resultPanel.Controls.Add(this.lblTotalInterest);
            this.resultPanel.Controls.Add(this.lblTotalPayment);
            this.resultPanel.Controls.Add(this.lblLoanAmountValue);
            this.resultPanel.Controls.Add(this.lblMonthlyPaymentValue);
            this.resultPanel.Controls.Add(this.lblGraceMonthlyValue);
            this.resultPanel.Controls.Add(this.lblFirstInterestValue);
            this.resultPanel.Controls.Add(this.lblFirstPrincipalValue);
            this.resultPanel.Controls.Add(this.lblTotalInterestValue);
            this.resultPanel.Controls.Add(this.lblTotalPaymentValue);
            this.resultPanel.Controls.Add(this.lblNote);
            this.resultPanel.Location = new System.Drawing.Point(0, 394);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(800, 230);
            this.resultPanel.TabIndex = 2;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.ForeColor = System.Drawing.Color.FromArgb(32, 52, 84);
            this.lblResultTitle.Location = new System.Drawing.Point(24, 18);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(92, 25);
            this.lblResultTitle.TabIndex = 0;
            this.lblResultTitle.Text = "試算結果";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblLoanAmount.Location = new System.Drawing.Point(30, 62);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(102, 22);
            this.lblLoanAmount.TabIndex = 1;
            this.lblLoanAmount.Text = "貸款總金額：";
            // 
            // lblLoanAmountValue
            // 
            this.lblLoanAmountValue.AutoSize = true;
            this.lblLoanAmountValue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoanAmountValue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblLoanAmountValue.Location = new System.Drawing.Point(190, 62);
            this.lblLoanAmountValue.Name = "lblLoanAmountValue";
            this.lblLoanAmountValue.Size = new System.Drawing.Size(17, 22);
            this.lblLoanAmountValue.TabIndex = 2;
            this.lblLoanAmountValue.Text = "-";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblMonthlyPayment.Location = new System.Drawing.Point(410, 62);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(142, 22);
            this.lblMonthlyPayment.TabIndex = 3;
            this.lblMonthlyPayment.Text = "每月應繳（本＋息）：";
            // 
            // lblMonthlyPaymentValue
            // 
            this.lblMonthlyPaymentValue.AutoSize = true;
            this.lblMonthlyPaymentValue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyPaymentValue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblMonthlyPaymentValue.Location = new System.Drawing.Point(570, 62);
            this.lblMonthlyPaymentValue.Name = "lblMonthlyPaymentValue";
            this.lblMonthlyPaymentValue.Size = new System.Drawing.Size(17, 22);
            this.lblMonthlyPaymentValue.TabIndex = 4;
            this.lblMonthlyPaymentValue.Text = "-";
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblFirstInterest.Location = new System.Drawing.Point(30, 96);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(82, 22);
            this.lblFirstInterest.TabIndex = 5;
            this.lblFirstInterest.Text = "首期利息：";
            // 
            // lblFirstInterestValue
            // 
            this.lblFirstInterestValue.AutoSize = true;
            this.lblFirstInterestValue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstInterestValue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblFirstInterestValue.Location = new System.Drawing.Point(190, 96);
            this.lblFirstInterestValue.Name = "lblFirstInterestValue";
            this.lblFirstInterestValue.Size = new System.Drawing.Size(17, 22);
            this.lblFirstInterestValue.TabIndex = 6;
            this.lblFirstInterestValue.Text = "-";
            // 
            // lblGraceMonthly
            // 
            this.lblGraceMonthly.AutoSize = true;
            this.lblGraceMonthly.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblGraceMonthly.Location = new System.Drawing.Point(410, 96);
            this.lblGraceMonthly.Name = "lblGraceMonthly";
            this.lblGraceMonthly.Size = new System.Drawing.Size(142, 22);
            this.lblGraceMonthly.TabIndex = 7;
            this.lblGraceMonthly.Text = "寬限期每月利息：";
            // 
            // lblGraceMonthlyValue
            // 
            this.lblGraceMonthlyValue.AutoSize = true;
            this.lblGraceMonthlyValue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraceMonthlyValue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblGraceMonthlyValue.Location = new System.Drawing.Point(570, 96);
            this.lblGraceMonthlyValue.Name = "lblGraceMonthlyValue";
            this.lblGraceMonthlyValue.Size = new System.Drawing.Size(17, 22);
            this.lblGraceMonthlyValue.TabIndex = 8;
            this.lblGraceMonthlyValue.Text = "-";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblTotalInterest.Location = new System.Drawing.Point(30, 130);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(102, 22);
            this.lblTotalInterest.TabIndex = 9;
            this.lblTotalInterest.Text = "總利息支出：";
            // 
            // lblTotalInterestValue
            // 
            this.lblTotalInterestValue.AutoSize = true;
            this.lblTotalInterestValue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalInterestValue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTotalInterestValue.Location = new System.Drawing.Point(190, 130);
            this.lblTotalInterestValue.Name = "lblTotalInterestValue";
            this.lblTotalInterestValue.Size = new System.Drawing.Size(17, 22);
            this.lblTotalInterestValue.TabIndex = 10;
            this.lblTotalInterestValue.Text = "-";
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblFirstPrincipal.Location = new System.Drawing.Point(410, 130);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(82, 22);
            this.lblFirstPrincipal.TabIndex = 11;
            this.lblFirstPrincipal.Text = "首期本金：";
            // 
            // lblFirstPrincipalValue
            // 
            this.lblFirstPrincipalValue.AutoSize = true;
            this.lblFirstPrincipalValue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstPrincipalValue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblFirstPrincipalValue.Location = new System.Drawing.Point(570, 130);
            this.lblFirstPrincipalValue.Name = "lblFirstPrincipalValue";
            this.lblFirstPrincipalValue.Size = new System.Drawing.Size(17, 22);
            this.lblFirstPrincipalValue.TabIndex = 12;
            this.lblFirstPrincipalValue.Text = "-";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblTotalPayment.Location = new System.Drawing.Point(410, 164);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(102, 22);
            this.lblTotalPayment.TabIndex = 13;
            this.lblTotalPayment.Text = "總還款金額：";
            // 
            // lblTotalPaymentValue
            // 
            this.lblTotalPaymentValue.AutoSize = true;
            this.lblTotalPaymentValue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentValue.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTotalPaymentValue.Location = new System.Drawing.Point(570, 164);
            this.lblTotalPaymentValue.Name = "lblTotalPaymentValue";
            this.lblTotalPaymentValue.Size = new System.Drawing.Size(17, 22);
            this.lblTotalPaymentValue.TabIndex = 14;
            this.lblTotalPaymentValue.Text = "-";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNote.Location = new System.Drawing.Point(30, 192);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(322, 19);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "寬限期內僅繳利息；期滿後依剩餘期數本息均攤";
            this.mainPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHousePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGracePeriod)).EndInit();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}