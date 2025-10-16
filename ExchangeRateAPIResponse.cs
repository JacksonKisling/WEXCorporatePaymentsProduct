using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEXCorporatePaymentsProduct
{
    public class ExchangeRateAPIResponse
    {
        public string country_currency_desc { get; set; }
        public string exchange_rate { get; set; }
        public DateTime? record_date { get; set; }
    }
}
