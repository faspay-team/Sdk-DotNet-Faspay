using System;
using System.Collections.Generic;

namespace FaspayApi.Entity
{
    public class FaspayPaymentStatusResponse
    {
        public string response { get; set; }
        public string trx_id { get; set; }
        public string merchant_id { get; set; }
        public string merchant { get; set; }
        public string bill_no { get; set; }
        public List<String> payment_reff { get; set; }
        public List<String> payment_date { get; set; }
        public string payment_status_code { get; set; }
        public string payment_status_desc { get; set; }
        public string response_code { get; set; }
        public string response_desc { get; set; }
        public FaspayPaymentStatusResponse()
        {
        }
    }
}
