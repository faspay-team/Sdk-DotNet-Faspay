using System;
namespace FaspaySDK.Credit.Entity.Payment.Wrapper
{
    public class FaspayPaymentCreditShippingdata
    {

        public   String receiver_name_for_shipping;
        public   String shipping_address;
        public   String shipping_address_city;
        public   String shipping_address_region;
        public   String shipping_address_state;
        public   String shipping_address_poscode;
        public   String shipping_address_country_code;
        public   String shippingcost;

        public FaspayPaymentCreditShippingdata(String shipping_address, String shipping_address_city, String shipping_address_region, String shipping_address_state, String shipping_address_poscode, String shipping_address_country_code, long shippingcost)
        {
            this.shipping_address = shipping_address;
            this.shipping_address_city = shipping_address_city;
            this.shipping_address_region = shipping_address_region;
            this.shipping_address_state = shipping_address_state;
            this.shipping_address_poscode = shipping_address_poscode;
            this.shipping_address_country_code = shipping_address_country_code;

            this.shippingcost = shippingcost.ToString("0.00");
        }

        public String getReceiver_name_for_shipping()
        {
            return receiver_name_for_shipping;
        }

        public void setReceiver_name_for_shipping(String receiver_name_for_shipping)
        {
            this.receiver_name_for_shipping = receiver_name_for_shipping;
        }

        public String getShipping_address()
        {
            return shipping_address;
        }

        public void setShipping_address(String shipping_address)
        {
            this.shipping_address = shipping_address;
        }

        public String getShipping_address_city()
        {
            return shipping_address_city;
        }

        public void setShipping_address_city(String shipping_address_city)
        {
            this.shipping_address_city = shipping_address_city;
        }

        public String getShipping_address_region()
        {
            return shipping_address_region;
        }

        public void setShipping_address_region(String shipping_address_region)
        {
            this.shipping_address_region = shipping_address_region;
        }

        public String getShipping_address_state()
        {
            return shipping_address_state;
        }

        public void setShipping_address_state(String shipping_address_state)
        {
            this.shipping_address_state = shipping_address_state;
        }

        public String getShipping_address_poscode()
        {
            return shipping_address_poscode;
        }

        public void setShipping_address_poscode(String shipping_address_poscode)
        {
            this.shipping_address_poscode = shipping_address_poscode;
        }

        public String getShipping_address_country_code()
        {
            return shipping_address_country_code;
        }

        public void setShipping_address_country_code(String shipping_address_country_code)
        {
            this.shipping_address_country_code = shipping_address_country_code;
        }

        public String getShippingcost()
        {
            return shippingcost;
        }

        public void setShippingcost(String shippingcost)
        {
            this.shippingcost = shippingcost;
        }


    }
        
}
