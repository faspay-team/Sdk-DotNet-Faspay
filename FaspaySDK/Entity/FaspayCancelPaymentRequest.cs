using System;
namespace FaspayApi.Entity
{
    public class FaspayCancelPaymentRequest
    {
        public string request { get; set; }
        public string trx_id { get; set; }
        public string merchant_id { get; set; }
        public string merchant { get; set; }
        public string bill_no { get; set; }
        public string payment_cancel { get; set; }
        public string signature { get; set; }
        public FaspayCancelPaymentRequest()
        {
        }
    }
}
