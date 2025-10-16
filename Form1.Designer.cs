
namespace WEXCorporatePaymentsProduct
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearTop = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClearBottom = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxExchangeRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxConvertedAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAmountUSD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSelectedDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStoredPurchaseTransactions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCurrencies = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.buttonClearTop);
            this.panel1.Controls.Add(this.buttonStore);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Location = new System.Drawing.Point(17, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 181);
            this.panel1.TabIndex = 1;
            // 
            // buttonClearTop
            // 
            this.buttonClearTop.Location = new System.Drawing.Point(924, 117);
            this.buttonClearTop.Name = "buttonClearTop";
            this.buttonClearTop.Size = new System.Drawing.Size(100, 40);
            this.buttonClearTop.TabIndex = 8;
            this.buttonClearTop.Text = "CLEAR";
            this.buttonClearTop.UseVisualStyleBackColor = true;
            this.buttonClearTop.Click += new System.EventHandler(this.buttonClearTop_Click);
            // 
            // buttonStore
            // 
            this.buttonStore.Location = new System.Drawing.Point(744, 117);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(100, 40);
            this.buttonStore.TabIndex = 7;
            this.buttonStore.Text = "STORE";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(744, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 29);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(744, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(396, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount in USD";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAmount.Location = new System.Drawing.Point(396, 56);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(280, 29);
            this.textBoxAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description (max 50 characters)";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(50, 56);
            this.textBoxDescription.MaxLength = 50;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(280, 29);
            this.textBoxDescription.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.buttonClearBottom);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxExchangeRate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxConvertedAmount);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBoxAmountUSD);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxSelectedDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.buttonCalculate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBoxStoredPurchaseTransactions);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxCurrencies);
            this.panel2.Location = new System.Drawing.Point(17, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 277);
            this.panel2.TabIndex = 2;
            // 
            // buttonClearBottom
            // 
            this.buttonClearBottom.Location = new System.Drawing.Point(922, 209);
            this.buttonClearBottom.Name = "buttonClearBottom";
            this.buttonClearBottom.Size = new System.Drawing.Size(100, 40);
            this.buttonClearBottom.TabIndex = 19;
            this.buttonClearBottom.Text = "CLEAR";
            this.buttonClearBottom.UseVisualStyleBackColor = true;
            this.buttonClearBottom.Click += new System.EventHandler(this.buttonClearBottom_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(394, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Exchange Rate";
            // 
            // textBoxExchangeRate
            // 
            this.textBoxExchangeRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExchangeRate.Location = new System.Drawing.Point(394, 134);
            this.textBoxExchangeRate.MaxLength = 50;
            this.textBoxExchangeRate.Name = "textBoxExchangeRate";
            this.textBoxExchangeRate.Size = new System.Drawing.Size(280, 29);
            this.textBoxExchangeRate.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(742, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Amount in Selected Currency";
            // 
            // textBoxConvertedAmount
            // 
            this.textBoxConvertedAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxConvertedAmount.Location = new System.Drawing.Point(742, 134);
            this.textBoxConvertedAmount.MaxLength = 50;
            this.textBoxConvertedAmount.Name = "textBoxConvertedAmount";
            this.textBoxConvertedAmount.Size = new System.Drawing.Size(280, 29);
            this.textBoxConvertedAmount.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(742, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Amount in US Dollars";
            // 
            // textBoxAmountUSD
            // 
            this.textBoxAmountUSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAmountUSD.Location = new System.Drawing.Point(742, 57);
            this.textBoxAmountUSD.MaxLength = 50;
            this.textBoxAmountUSD.Name = "textBoxAmountUSD";
            this.textBoxAmountUSD.Size = new System.Drawing.Size(280, 29);
            this.textBoxAmountUSD.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(48, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Selected Transaction Date";
            // 
            // textBoxSelectedDate
            // 
            this.textBoxSelectedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSelectedDate.Location = new System.Drawing.Point(48, 209);
            this.textBoxSelectedDate.MaxLength = 50;
            this.textBoxSelectedDate.Name = "textBoxSelectedDate";
            this.textBoxSelectedDate.Size = new System.Drawing.Size(280, 29);
            this.textBoxSelectedDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(48, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Selected Transaction ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(48, 134);
            this.textBoxID.MaxLength = 50;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(280, 29);
            this.textBoxID.TabIndex = 9;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(744, 209);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 40);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stored Purchase Transactions";
            // 
            // comboBoxStoredPurchaseTransactions
            // 
            this.comboBoxStoredPurchaseTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStoredPurchaseTransactions.FormattingEnabled = true;
            this.comboBoxStoredPurchaseTransactions.Location = new System.Drawing.Point(48, 57);
            this.comboBoxStoredPurchaseTransactions.Name = "comboBoxStoredPurchaseTransactions";
            this.comboBoxStoredPurchaseTransactions.Size = new System.Drawing.Size(280, 29);
            this.comboBoxStoredPurchaseTransactions.TabIndex = 2;
            this.comboBoxStoredPurchaseTransactions.SelectedIndexChanged += new System.EventHandler(this.comboBoxStoredPurchaseTransactions_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(394, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Currencies";
            // 
            // comboBoxCurrencies
            // 
            this.comboBoxCurrencies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCurrencies.FormattingEnabled = true;
            this.comboBoxCurrencies.Location = new System.Drawing.Point(394, 57);
            this.comboBoxCurrencies.Name = "comboBoxCurrencies";
            this.comboBoxCurrencies.Size = new System.Drawing.Size(280, 29);
            this.comboBoxCurrencies.TabIndex = 0;
            this.comboBoxCurrencies.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencies_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1098, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "WEX Purchase Transaction Storage Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClearTop;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCurrencies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStoredPurchaseTransactions;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxConvertedAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAmountUSD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSelectedDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxExchangeRate;
        private System.Windows.Forms.Button buttonClearBottom;
    }
}

