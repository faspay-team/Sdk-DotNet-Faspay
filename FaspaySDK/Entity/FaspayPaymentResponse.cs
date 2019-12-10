using System;
using System.Collections.Generic;

namespace FaspayApi.Entity
{
    public class FaspayPaymentResponse
    {
        public FaspayPaymentResponse()
        {
        }
        public string response { get; set; }
        public string trx_id { get; set; }
        public string merchant_id { get; set; }
        public string merchant { get; set; }
        public string bill_no { get; set; }
        public List<BillItem> bill_items { get; set; }
        public string response_code { get; set; }
        public string response_desc { get; set; }
    }
}
