using System;
using System.Collections.Generic;

namespace FaspayApi.Entity
{
    public class FaspayPaymentRequestBillData
    {
        public FaspayPaymentRequestBillData()
        {

        }
        public string bill_no { get; set; }
        public string bill_reff { get; set; }
        public string bill_date { get; set; }
        public string bill_expired { get; set; }
        public string bill_desc { get; set; }
        public string bill_currency { get; set; }
        public string bill_gross { get; set; }
        public string bill_tax { get; set; }
        public string bill_miscfee { get; set; }
        public string bill_total { get; set; }
        public string billing_name { get; set; }
        public string billing_lastname { get; set; }
        public string billing_address { get; set; }
        public string billing_address_city { get; set; }
        public string billing_address_region { get; set; }
        public string billing_address_state { get; set; }
        public string billing_address_poscode { get; set; }
        public string billing_msisdn { get; set; }
        public string billing_address_country_code { get; set; }
        public string pay_type { get; set; }


        public List<FaspayPayment> item { get; set; } = new List<FaspayPayment>();

        public FaspayPaymentRequestBillData(String billNo, String billDesc, int expired_day_interval, String billTotal, List<FaspayPayment> item, int pay_type)
        {
            DateTime now = DateTime.Now;
            bill_no = billNo;
            bill_desc = billDesc;
            bill_date = now.ToString("yyyy-MM-dd hh:mm:ss");
            now = now.AddDays(expired_day_interval);
            bill_expired = now.ToString("yyyy-MM-dd hh:mm:ss");
            bill_total = billTotal;
            this.item = item;
            this.pay_type = pay_type.ToString();
            String q = $"hari ini sama {now}";


        }
    }
}
