namespace _forexcalculator
{
    public partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.accountBal = new System.Windows.Forms.TextBox();
            this.risk = new System.Windows.Forms.TextBox();
            this.entryPrice = new System.Windows.Forms.TextBox();
            this.slPrice = new System.Windows.Forms.TextBox();
            this.curPair = new System.Windows.Forms.ListBox();
            this.lotSize = new System.Windows.Forms.Label();
            this.stopLossPrice = new System.Windows.Forms.Label();
            this.riskAmount = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.RadioButton();
            this.amount = new System.Windows.Forms.RadioButton();
            this.riskPanel = new System.Windows.Forms.Panel();
            this.buyOrSellPanel = new System.Windows.Forms.Panel();
            this.riskPanel.SuspendLayout();
            this.buyOrSellPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forex Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Risk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Currency Pair:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entry Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "StopLoss Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 30);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Buy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.buy_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(110, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 30);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sell";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.sell_CheckedChanged);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Green;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(47, 730);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(192, 41);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculateBtn);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Red;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(279, 730);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(192, 41);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // accountBal
            // 
            this.accountBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBal.Location = new System.Drawing.Point(309, 109);
            this.accountBal.Name = "accountBal";
            this.accountBal.Size = new System.Drawing.Size(187, 32);
            this.accountBal.TabIndex = 12;
            this.accountBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.accountBal.TextChanged += new System.EventHandler(this.accountBal_TextChanged);
            // 
            // risk
            // 
            this.risk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.risk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risk.Location = new System.Drawing.Point(309, 202);
            this.risk.Name = "risk";
            this.risk.Size = new System.Drawing.Size(187, 32);
            this.risk.TabIndex = 13;
            this.risk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.risk.TextChanged += new System.EventHandler(this.risk_TextChanged);
            // 
            // entryPrice
            // 
            this.entryPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryPrice.Location = new System.Drawing.Point(309, 403);
            this.entryPrice.Name = "entryPrice";
            this.entryPrice.Size = new System.Drawing.Size(187, 32);
            this.entryPrice.TabIndex = 14;
            this.entryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.entryPrice.TextChanged += new System.EventHandler(this.entryPrice_TextChanged);
            // 
            // slPrice
            // 
            this.slPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slPrice.Location = new System.Drawing.Point(309, 514);
            this.slPrice.Name = "slPrice";
            this.slPrice.Size = new System.Drawing.Size(187, 32);
            this.slPrice.TabIndex = 15;
            this.slPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.slPrice.TextChanged += new System.EventHandler(this.slPrice_TextChanged);
            // 
            // curPair
            // 
            this.curPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curPair.FormattingEnabled = true;
            this.curPair.ItemHeight = 26;
            this.curPair.Items.AddRange(new object[] {
            "EURUSD",
            "GBPUSD",
            "USDJPY",
            "GBPJPY",
            "EURJPY",
            "XAUUSD",
            "XAGUSD",
            "US100",
            "US30"});
            this.curPair.Location = new System.Drawing.Point(309, 304);
            this.curPair.Name = "curPair";
            this.curPair.Size = new System.Drawing.Size(187, 54);
            this.curPair.TabIndex = 16;
            this.curPair.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lotSize
            // 
            this.lotSize.AutoSize = true;
            this.lotSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotSize.Location = new System.Drawing.Point(865, 112);
            this.lotSize.Name = "lotSize";
            this.lotSize.Size = new System.Drawing.Size(111, 29);
            this.lotSize.TabIndex = 17;
            this.lotSize.Text = "Lot Size :";
            // 
            // stopLossPrice
            // 
            this.stopLossPrice.AutoSize = true;
            this.stopLossPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLossPrice.Location = new System.Drawing.Point(865, 189);
            this.stopLossPrice.Name = "stopLossPrice";
            this.stopLossPrice.Size = new System.Drawing.Size(54, 29);
            this.stopLossPrice.TabIndex = 18;
            this.stopLossPrice.Text = "SL :";
            // 
            // riskAmount
            // 
            this.riskAmount.AutoSize = true;
            this.riskAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskAmount.Location = new System.Drawing.Point(865, 248);
            this.riskAmount.Name = "riskAmount";
            this.riskAmount.Size = new System.Drawing.Size(159, 29);
            this.riskAmount.TabIndex = 19;
            this.riskAmount.Text = "Risk Amount :";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.Location = new System.Drawing.Point(16, 14);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(52, 26);
            this.percentage.TabIndex = 20;
            this.percentage.TabStop = true;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = true;
            this.percentage.CheckedChanged += new System.EventHandler(this.percentage_CheckedChanged);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(94, 14);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(46, 26);
            this.amount.TabIndex = 21;
            this.amount.TabStop = true;
            this.amount.Text = "£";
            this.amount.UseVisualStyleBackColor = true;
            this.amount.CheckedChanged += new System.EventHandler(this.amount_CheckedChanged);
            // 
            // riskPanel
            // 
            this.riskPanel.BackColor = System.Drawing.Color.Transparent;
            this.riskPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.riskPanel.Controls.Add(this.percentage);
            this.riskPanel.Controls.Add(this.amount);
            this.riskPanel.Location = new System.Drawing.Point(502, 189);
            this.riskPanel.Name = "riskPanel";
            this.riskPanel.Size = new System.Drawing.Size(145, 45);
            this.riskPanel.TabIndex = 24;
            // 
            // buyOrSellPanel
            // 
            this.buyOrSellPanel.BackColor = System.Drawing.Color.Transparent;
            this.buyOrSellPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyOrSellPanel.Controls.Add(this.radioButton1);
            this.buyOrSellPanel.Controls.Add(this.radioButton2);
            this.buyOrSellPanel.Location = new System.Drawing.Point(309, 591);
            this.buyOrSellPanel.Name = "buyOrSellPanel";
            this.buyOrSellPanel.Size = new System.Drawing.Size(187, 52);
            this.buyOrSellPanel.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 853);
            this.Controls.Add(this.buyOrSellPanel);
            this.Controls.Add(this.riskPanel);
            this.Controls.Add(this.riskAmount);
            this.Controls.Add(this.stopLossPrice);
            this.Controls.Add(this.lotSize);
            this.Controls.Add(this.curPair);
            this.Controls.Add(this.slPrice);
            this.Controls.Add(this.entryPrice);
            this.Controls.Add(this.risk);
            this.Controls.Add(this.accountBal);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.riskPanel.ResumeLayout(false);
            this.riskPanel.PerformLayout();
            this.buyOrSellPanel.ResumeLayout(false);
            this.buyOrSellPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox accountBal;
        private System.Windows.Forms.TextBox risk;
        private System.Windows.Forms.TextBox entryPrice;
        private System.Windows.Forms.TextBox slPrice;
        private System.Windows.Forms.ListBox curPair;
        private System.Windows.Forms.Label lotSize;
        private System.Windows.Forms.Label stopLossPrice;
        private System.Windows.Forms.Label riskAmount;
        private System.Windows.Forms.RadioButton percentage;
        private System.Windows.Forms.RadioButton amount;
        private System.Windows.Forms.Panel riskPanel;
        private System.Windows.Forms.Panel buyOrSellPanel;
    }
}

