using System;
namespace FaspaySDK.Credit.Entity.Payment.Wrapper
{
    public class FaspayPaymentCreditBillData
    {
        public   String billing_address;
        public   String billing_address_city;
        public   String billing_address_region;
        public   String billing_address_state;
        public   String billing_address_poscode;
        public   String billing_address_country_code;

        public FaspayPaymentCreditBillData(String billing_address, String billing_address_city, String billing_address_region, String billing_address_state, String billing_address_poscode, String billing_address_country_code)
        {
            this.billing_address = billing_address;
            this.billing_address_city = billing_address_city;
            this.billing_address_region = billing_address_region;
            this.billing_address_state = billing_address_state;
            this.billing_address_poscode = billing_address_poscode;
            this.billing_address_country_code = billing_address_country_code;
        }

        public String getBilling_address()
        {
            return billing_address;
        }

        public void setBilling_address(String billing_address)
        {
            this.billing_address = billing_address;
        }

        public String getBilling_address_city()
        {
            return billing_address_city;
        }

        public void setBilling_address_city(String billing_address_city)
        {
            this.billing_address_city = billing_address_city;
        }

        public String getBilling_address_region()
        {
            return billing_address_region;
        }

        public void setBilling_address_region(String billing_address_region)
        {
            this.billing_address_region = billing_address_region;
        }

        public String getBilling_address_state()
        {
            return billing_address_state;
        }

        public void setBilling_address_state(String billing_address_state)
        {
            this.billing_address_state = billing_address_state;
        }

        public String getBilling_address_poscode()
        {
            return billing_address_poscode;
        }

        public void setBilling_address_poscode(String billing_address_poscode)
        {
            this.billing_address_poscode = billing_address_poscode;
        }

        public String getBilling_address_country_code()
        {
            return billing_address_country_code;
        }

        public void setBilling_address_country_code(String billing_address_country_code)
        {
            this.billing_address_country_code = billing_address_country_code;
        }
    }
}
