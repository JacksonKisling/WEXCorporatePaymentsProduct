using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEXCorporatePaymentsProduct
{
    public class PurchaseTransactionAPI
    {
        public PurchaseTransactionAPI(HttpClient client) // used by test class
        {
            httpClient = client;
        }
        
        protected readonly HttpClient httpClient = new HttpClient();
        private string baseAPI = "https://api.fiscaldata.treasury.gov/services/api/fiscal_service/v1/accounting/od/rates_of_exchange";
        private string fields = "?fields=country_currency_desc,exchange_rate,record_date";
        public string buildRequest(PurchaseTransaction pt, string currency)
        {
            var dateMinusSixMonths = pt.transactionDate.AddMonths(-6).ToString("yyyy-MM-dd");
            string parameters = $"&filter=country_currency_desc:in:({currency}),record_date:gte:{dateMinusSixMonths}";
            return baseAPI + fields + parameters;
        }

        private async Task<List<ExchangeRateAPIResponse>> getExchangeRates(PurchaseTransaction pt, string currency)
        {
            string requestString = buildRequest(pt, currency);
            var emptyResponse = new List<ExchangeRateAPIResponse>();
            try
            {
                using var client = await httpClient.GetAsync(requestString);
                client.EnsureSuccessStatusCode();

                var json = await client.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var response = JsonSerializer.Deserialize<ApiDataWrapper>(json, options);

                return response.data != null ? response.data : emptyResponse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching transactions: {ex.Message}");
                return emptyResponse;
            }
        }

        public async Task<string> getRequestedExchangeRate(PurchaseTransaction pt, string currency)
        {
            try
            {
                var apiResponse = await getExchangeRates(pt, currency);
                if (apiResponse != null && apiResponse.Count > 0)
                {
                    apiResponse.RemoveAll(x => x.country_currency_desc != currency || x.record_date > pt.transactionDate);
                    var responseItem = apiResponse.OrderByDescending(x => x.record_date).FirstOrDefault();
                    if (responseItem != null)
                        return responseItem.exchange_rate;
                }
                MessageBox.Show($"Found no suitable exchange rates for that country and date.");
                return "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting requested exchange rate: {ex.Message}");
                return "0";
            }
        }

    }

    public class ApiDataWrapper
    {
        public List<ExchangeRateAPIResponse> data { get; set; }
    }
}
