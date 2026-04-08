namespace MortgageCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label lblGracePeriod;

        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtGracePeriod;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalPayment;

        private System.Windows.Forms.Label lblLoanAmountValue;
        private System.Windows.Forms.Label lblMonthlyPaymentValue;
        private System.Windows.Forms.Label lblFirstInterestValue;
        private System.Windows.Forms.Label lblFirstPrincipalValue;
        private System.Windows.Forms.Label lblTotalInterestValue;
        private System.Windows.Forms.Label lblTotalPaymentValue;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.lblGracePeriod = new System.Windows.Forms.Label();

            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();

            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();

            this.lblLoanAmountValue = new System.Windows.Forms.Label();
            this.lblMonthlyPaymentValue = new System.Windows.Forms.Label();
            this.lblFirstInterestValue = new System.Windows.Forms.Label();
            this.lblFirstPrincipalValue = new System.Windows.Forms.Label();
            this.lblTotalInterestValue = new System.Windows.Forms.Label();
            this.lblTotalPaymentValue = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Name = "Form1";
            this.Text = "個人房貸試算器";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 35);
            this.lblTitle.Text = "個人房貸試算器";

            // lblHousePrice
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.Location = new System.Drawing.Point(30, 80);
            this.lblHousePrice.Text = "房屋總價（元）";

            // txtHousePrice
            this.txtHousePrice.Location = new System.Drawing.Point(180, 76);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(180, 27);
            this.txtHousePrice.Text = "10000000";

            // lblDownPayment
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(30, 120);
            this.lblDownPayment.Text = "自備款比例（%）";

            // txtDownPayment
            this.txtDownPayment.Location = new System.Drawing.Point(180, 116);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(180, 27);
            this.txtDownPayment.Text = "20";

            // lblInterestRate
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(30, 160);
            this.lblInterestRate.Text = "年利率（%）";

            // txtInterestRate
            this.txtInterestRate.Location = new System.Drawing.Point(180, 156);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(180, 27);
            this.txtInterestRate.Text = "2.15";

            // lblLoanTerm
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Location = new System.Drawing.Point(30, 200);
            this.lblLoanTerm.Text = "貸款年限（年）";

            // txtLoanTerm
            this.txtLoanTerm.Location = new System.Drawing.Point(180, 196);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(180, 27);
            this.txtLoanTerm.Text = "20";

            // lblGracePeriod
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.Location = new System.Drawing.Point(30, 240);
            this.lblGracePeriod.Text = "寬限期（年）";

            // txtGracePeriod
            this.txtGracePeriod.Location = new System.Drawing.Point(180, 236);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(180, 27);
            this.txtGracePeriod.Text = "0";

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(30, 290);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 40);
            this.btnCalculate.Text = "開始試算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(190, 290);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 40);
            this.btnReset.Text = "重設";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 結果 labels
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(420, 80);
            this.lblLoanAmount.Text = "貸款總金額：";

            this.lblLoanAmountValue.AutoSize = true;
            this.lblLoanAmountValue.Location = new System.Drawing.Point(560, 80);
            this.lblLoanAmountValue.Text = "-";

            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(420, 120);
            this.lblMonthlyPayment.Text = "每月應繳金額：";

            this.lblMonthlyPaymentValue.AutoSize = true;
            this.lblMonthlyPaymentValue.Location = new System.Drawing.Point(560, 120);
            this.lblMonthlyPaymentValue.Text = "-";

            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Location = new System.Drawing.Point(420, 160);
            this.lblFirstInterest.Text = "首期利息：";

            this.lblFirstInterestValue.AutoSize = true;
            this.lblFirstInterestValue.Location = new System.Drawing.Point(560, 160);
            this.lblFirstInterestValue.Text = "-";

            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Location = new System.Drawing.Point(420, 200);
            this.lblFirstPrincipal.Text = "首期本金：";

            this.lblFirstPrincipalValue.AutoSize = true;
            this.lblFirstPrincipalValue.Location = new System.Drawing.Point(560, 200);
            this.lblFirstPrincipalValue.Text = "-";

            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(420, 240);
            this.lblTotalInterest.Text = "總利息支出：";

            this.lblTotalInterestValue.AutoSize = true;
            this.lblTotalInterestValue.Location = new System.Drawing.Point(560, 240);
            this.lblTotalInterestValue.Text = "-";

            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(420, 280);
            this.lblTotalPayment.Text = "總還款金額：";

            this.lblTotalPaymentValue.AutoSize = true;
            this.lblTotalPaymentValue.Location = new System.Drawing.Point(560, 280);
            this.lblTotalPaymentValue.Text = "-";

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHousePrice);
            this.Controls.Add(this.txtHousePrice);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.lblGracePeriod);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);

            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.lblLoanAmountValue);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.lblMonthlyPaymentValue);
            this.Controls.Add(this.lblFirstInterest);
            this.Controls.Add(this.lblFirstInterestValue);
            this.Controls.Add(this.lblFirstPrincipal);
            this.Controls.Add(this.lblFirstPrincipalValue);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.lblTotalInterestValue);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblTotalPaymentValue);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}