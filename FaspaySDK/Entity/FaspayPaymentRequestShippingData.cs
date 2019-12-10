using System;
namespace FaspayApi.Entity
{
    public class FaspayPaymentRequestShippingData
    {
        public string receiver_name_for_shipping { get; set; } = "";
        public string shipping_lastname { get; set; } = "";
        public string shipping_address { get; set; } = "";
        public string shipping_address_city { get; set; } = "";
        public string shipping_address_region { get; set; } = "";
        public string shipping_address_state { get; set; } = "";
        public string shipping_address_poscode { get; set; } = "";
        public string shipping_msisdn { get; set; } = "";
        public string shipping_address_country_code = "ID";
        public FaspayPaymentRequestShippingData()
        {

        }
    }
}
