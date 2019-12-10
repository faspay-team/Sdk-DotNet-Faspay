using System;
namespace FaspaySDK.Credit.Conf
{
    public class FaspayUserCredit
    {
        public FaspayUserCredit()
        {
        }
        String merchantId;
        String pass;

        public String getMerchantId()
        {
            return merchantId;
        }

        public void setMerchantId(String merchantId)
        {
            this.merchantId = merchantId;
        }

        public String getPass()
        {
            return pass;
        }

        public void setPass(String pass)
        {
            this.pass = pass;
        }
    }
}
