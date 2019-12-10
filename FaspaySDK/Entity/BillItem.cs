using System;
namespace FaspayApi.Entity
{
    public class BillItem
    {
        public string product { get; set; }
        public string qty { get; set; }
        public string amount { get; set; }
        public string payment_plan { get; set; }
        public string merchant_id { get; set; }
        public string tenor { get; set; }
        public BillItem()
        {
        }
    }
}
