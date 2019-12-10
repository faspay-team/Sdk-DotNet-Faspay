using System;
namespace FaspaySDK.Credit.Entity.Payment.Wrapper
{
    public class FaspayPaymentCreditCardData
    {
        public    String card_issuer_bank;
        public    String card_identity_ref_type;
        public    String card_identity_ref;
        public    String card_phone;
        public    String card_bill_addr;
        public    String card_bill_addr_poscode;
        public    String card_bill_addr_city;
        public    String card_bill_addr_region;
        public    String card_bill_addr_state;
        public    String card_bill_addr_country_code;
        public    String card_email;

        public String getCard_issuer_bank()
        {
            return card_issuer_bank;
        }

        public void setCard_issuer_bank(String card_issuer_bank)
        {
            this.card_issuer_bank = card_issuer_bank;
        }

        public String getCard_identity_ref_type()
        {
            return card_identity_ref_type;
        }

        public void setCard_identity_ref_type(String card_identity_ref_type)
        {
            this.card_identity_ref_type = card_identity_ref_type;
        }

        public String getCard_identity_ref()
        {
            return card_identity_ref;
        }

        public void setCard_identity_ref(String card_identity_ref)
        {
            this.card_identity_ref = card_identity_ref;
        }

        public String getCard_phone()
        {
            return card_phone;
        }

        public void setCard_phone(String card_phone)
        {
            this.card_phone = card_phone;
        }

        public String getCard_bill_addr()
        {
            return card_bill_addr;
        }

        public void setCard_bill_addr(String card_bill_addr)
        {
            this.card_bill_addr = card_bill_addr;
        }

        public String getCard_bill_addr_poscode()
        {
            return card_bill_addr_poscode;
        }

        public void setCard_bill_addr_poscode(String card_bill_addr_poscode)
        {
            this.card_bill_addr_poscode = card_bill_addr_poscode;
        }

        public String getCard_bill_addr_city()
        {
            return card_bill_addr_city;
        }

        public void setCard_bill_addr_city(String card_bill_addr_city)
        {
            this.card_bill_addr_city = card_bill_addr_city;
        }

        public String getCard_bill_addr_region()
        {
            return card_bill_addr_region;
        }

        public void setCard_bill_addr_region(String card_bill_addr_region)
        {
            this.card_bill_addr_region = card_bill_addr_region;
        }

        public String getCard_bill_addr_state()
        {
            return card_bill_addr_state;
        }

        public void setCard_bill_addr_state(String card_bill_addr_state)
        {
            this.card_bill_addr_state = card_bill_addr_state;
        }

        public String getCard_bill_addr_country_code()
        {
            return card_bill_addr_country_code;
        }

        public void setCard_bill_addr_country_code(String card_bill_addr_country_code)
        {
            this.card_bill_addr_country_code = card_bill_addr_country_code;
        }

        public String getCard_email()
        {
            return card_email;
        }

        public void setCard_email(String card_email)
        {
            this.card_email = card_email;
        }
    }
}
