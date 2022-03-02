using System;
using System.Collections.Generic;

namespace FaspayApi.Entity
{
    public class FaspayPaymentRequest
    {
        public string request { get; set; }
        public string merchant_id { get; set; }
        public string merchant { get; set; }
        public string bill_no { get; set; }
        public string bill_reff { get; set; }
        public string bill_date { get; set; }
        public string bill_expired { get; set; }
        public string bill_desc { get; set; }
        public string bill_currency { get; set; }
        public string bill_gross { get; set; }
        public string bill_miscfee { get; set; }
        public string bill_total { get; set; }
        public string cust_no { get; set; }
        public string cust_name { get; set; }
        public string payment_channel { get; set; }
        public string pay_type { get; set; }
        public string bank_userid { get; set; }
        public string msisdn { get; set; }
        public string email { get; set; }
        public string terminal { get; set; }
        public string billing_name { get; set; }
        public string billing_lastname { get; set; }
        public string billing_address { get; set; }
        public string billing_address_city { get; set; }
        public string billing_address_region { get; set; }
        public string billing_address_state { get; set; }
        public string billing_address_poscode { get; set; }
        public string billing_msisdn { get; set; }
        public string billing_address_country_code { get; set; }
        public string receiver_name_for_shipping { get; set; }
        public string shipping_lastname { get; set; }
        public string shipping_address { get; set; }
        public string shipping_address_city { get; set; }
        public string shipping_address_region { get; set; }
        public string shipping_address_state { get; set; }
        public string shipping_address_poscode { get; set; }
        public string shipping_msisdn { get; set; }
        public string shipping_address_country_code { get; set; }
        public List<FaspayPayment> item { get; set; }
        public string reserve1 { get; set; }
        public string reserve2 { get; set; }
        public string trx_source { get; set; }
        public string signature { get; set; }
        public FaspayPaymentRequest()
        {
        }
    }
}
