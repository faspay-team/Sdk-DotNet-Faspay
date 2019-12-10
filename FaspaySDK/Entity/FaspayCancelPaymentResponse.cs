using System;
namespace FaspayApi.Entity
{
    public class FaspayCancelPaymentResponse
    {
        public string response { get; set; }
        public string trx_id { get; set; }
        public string merchant_id { get; set; }
        public string merchant { get; set; }
        public string bill_no { get; set; }
        public string trx_status_code { get; set; }
        public string trx_status_desc { get; set; }
        public string payment_status_code { get; set; }
        public string payment_status_desc { get; set; }
        public string payment_cancel_date { get; set; }
        public string payment_cancel { get; set; }
        public string response_code { get; set; }
        public string response_desc { get; set; }

        public FaspayCancelPaymentResponse()
        {
        
        }
    }
}
