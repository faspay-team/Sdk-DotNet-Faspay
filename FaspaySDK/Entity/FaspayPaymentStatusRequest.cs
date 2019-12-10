using System;
namespace FaspayApi.Entity
{
    public class FaspayPaymentStatusRequest
    {
        public FaspayPaymentStatusRequest()
        {

        }
        public string request { get; set; }
        public string trx_id { get; set; }
        public string merchant_id { get; set; }
        public string bill_no { get; set; }
        public string signature { get; set; }
    }
}
