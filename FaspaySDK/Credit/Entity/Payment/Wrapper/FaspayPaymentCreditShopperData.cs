using System;
namespace FaspaySDK.Credit.Entity.Payment.Wrapper
{
    public class FaspayPaymentCreditShopperData
    {
        public String custname;
        public String custemail;
        public String shopper_ip;
        public String description;
        public String cardno;
        public String cardname;
        public char cardtype;
        public String expirymonth;
        public String expiryyear;
        public String cardcvc;
        public String card_issuer_bank_country_code;
        public String phone_no;
        public String customer_ref;

        public String getCustomer_ref()
        {
            return customer_ref;
        }

        public void setCustomer_ref(String customer_ref)
        {
            this.customer_ref = customer_ref;
        }

        public FaspayPaymentCreditShopperData(String custname, String custemail, String shopper_ip, String description, String cardno, String cardname, char cardtype, int expirymonth, String expiryyear, String phone_no)
        {
            this.custname = custname;
            this.custemail = custemail;
            this.phone_no = phone_no;
            this.shopper_ip = shopper_ip;
            this.description = description;
            this.cardno = cardno;
            this.cardname = cardname;
            this.cardtype = cardtype;

            this.expirymonth = expirymonth.ToString("00");
            this.expiryyear = expiryyear;
        }

        public String getCustname()
        {
            return custname;
        }

        public void setCustname(String custname)
        {
            this.custname = custname;
        }

        public String getCustemail()
        {
            return custemail;
        }

        public void setCustemail(String custemail)
        {
            this.custemail = custemail;
        }

        public String getShopper_ip()
        {
            return shopper_ip;
        }

        public void setShopper_ip(String shopper_ip)
        {
            this.shopper_ip = shopper_ip;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getCardno()
        {
            return cardno;
        }

        public void setCardno(String cardno)
        {
            this.cardno = cardno;
        }

        public String getCardname()
        {
            return cardname;
        }

        public void setCardname(String cardname)
        {
            this.cardname = cardname;
        }

        public char getCardtype()
        {
            return cardtype;
        }

        public void setCardtype(char cardtype)
        {
            this.cardtype = cardtype;
        }

        public String getExpirymonth()
        {
            return expirymonth;
        }

        public void setExpirymonth(String expirymonth)
        {
            this.expirymonth = expirymonth;
        }

        public String getExpiryyear()
        {
            return expiryyear;
        }

        public void setExpiryyear(String expiryyear)
        {
            this.expiryyear = expiryyear;
        }

        public String getCardcvc()
        {
            return cardcvc;
        }

        public void setCardcvc(String cardcvc)
        {
            this.cardcvc = cardcvc;
        }

        public String getCard_issuer_bank_country_code()
        {
            return card_issuer_bank_country_code;
        }

        public void setCard_issuer_bank_country_code(String card_issuer_bank_country_code)
        {
            this.card_issuer_bank_country_code = card_issuer_bank_country_code;
        }

        public String getPhone_no()
        {
            return phone_no;
        }

        public void setPhone_no(String phone_no)
        {
            this.phone_no = phone_no;
        }
    }
}
