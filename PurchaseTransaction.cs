using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WEXCorporatePaymentsProduct
{
    public class PurchaseTransaction
    {
        public Guid id { get; set; }
        public string description { get; set; }
        public DateTime transactionDate { get; set; }
        public decimal purchaseAmount { get; set; }

        public PurchaseTransaction(string desc, DateTime d, decimal amount)
        {
            description = desc;
            transactionDate = d;
            purchaseAmount = amount;
            id = Guid.NewGuid();
        }

        public PurchaseTransaction() { }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
