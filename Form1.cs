using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEXCorporatePaymentsProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialize();
        }

        public string selectedCurrency { get; set; }
        public DateTime? selectedDate { get; set; }


        public void initialize()
        {
            loadTransactions();
            comboBoxStoredPurchaseTransactions.DisplayMember = "description";
            comboBoxStoredPurchaseTransactions.ValueMember = "id";
            List<string> currencies = new List<string>() { "Canada-Dollar", "China-Renminbi", "Euro Zone-Euro", "Japan-Yen", "Mexico-Peso" };
            comboBoxCurrencies.DataSource = currencies;
            buttonCalculate.Enabled = false;
            textBoxID.Text = string.Empty;
            textBoxSelectedDate.Text = string.Empty;
            textBoxAmountUSD.Text = string.Empty;
            comboBoxCurrencies.SelectedIndex = -1;
            comboBoxStoredPurchaseTransactions.SelectedIndex = -1;
            selectedDate = null;
            selectedCurrency = null;
            buttonCalculate.Enabled = false;
        }

        private void loadTransactions()
        {
            List<PurchaseTransaction> transactions = PurchaseTransactionIO.readAllPurchaseTransactions();
            comboBoxStoredPurchaseTransactions.DataSource = transactions;
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            try
            {
                var form_description = this.textBoxDescription.Text;
                var form_amount = Convert.ToDecimal(this.textBoxAmount.Text);
                var form_date = Convert.ToDateTime(this.dateTimePicker1.Text);
                var pt = new PurchaseTransaction(form_description, form_date, form_amount);
                string result = PurchaseTransactionIO.writePurchaseTransaction(pt);
                if (result.Contains("Successfully"))
                    loadTransactions();
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in storage method: {ex.ToString()}");
            }
        }

        private void buttonClearTop_Click(object sender, EventArgs e)
        {
            this.textBoxDescription.Text = string.Empty;
            this.textBoxAmount.Text = string.Empty;
            this.dateTimePicker1.Value = DateTime.UtcNow;
        }

        private async void buttonCalculate_Click(object sender, EventArgs e)
        {
            var api = new PurchaseTransactionAPI(new System.Net.Http.HttpClient());
            var pt = comboBoxStoredPurchaseTransactions.SelectedItem as PurchaseTransaction;
            string currency = comboBoxCurrencies.SelectedItem.ToString();
            string exchangeRate = await api.getRequestedExchangeRate(pt, currency);
            if (string.IsNullOrEmpty(exchangeRate))
                throw new Exception("Could not find suitable exchange rate for country and date");
            else
            {
                textBoxExchangeRate.Text = exchangeRate;
                textBoxAmountUSD.Text = pt.purchaseAmount.ToString();
                decimal convertedAmount = Convert.ToDecimal(exchangeRate) * pt.purchaseAmount;
                textBoxConvertedAmount.Text = Math.Round(convertedAmount, 2).ToString();
            }
        }

        private void buttonClearBottom_Click(object sender, EventArgs e)
        {
            comboBoxCurrencies.SelectedIndex = -1;
            comboBoxStoredPurchaseTransactions.SelectedIndex = -1;
            textBoxID.Text = string.Empty;
            textBoxSelectedDate.Text = string.Empty;
            textBoxExchangeRate.Text = string.Empty;
            textBoxAmountUSD.Text = string.Empty;
            textBoxConvertedAmount.Text = string.Empty;
        }

        private void comboBoxCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCurrencies.SelectedIndex != -1)
            {
                selectedCurrency = comboBoxCurrencies.SelectedItem.ToString();
                buttonCalculate.Enabled = comboBoxStoredPurchaseTransactions.SelectedIndex != -1;
            }
        }

        private void comboBoxStoredPurchaseTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPurchaseTransaction = comboBoxStoredPurchaseTransactions.SelectedItem as PurchaseTransaction;
            if (comboBoxStoredPurchaseTransactions.SelectedIndex != -1)
            {
                selectedDate = selectedPurchaseTransaction.transactionDate;
                buttonCalculate.Enabled = !string.IsNullOrEmpty(selectedCurrency);
                textBoxAmountUSD.Text = selectedPurchaseTransaction.purchaseAmount.ToString();
                textBoxID.Text = selectedPurchaseTransaction.id.ToString();
                textBoxSelectedDate.Text = selectedPurchaseTransaction.transactionDate.ToString("yyyy/MM/dd");
            }
        }
    }
}
