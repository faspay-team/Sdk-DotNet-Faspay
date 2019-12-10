using System;
namespace FaspaySDK.Credit.Conf
{
    public abstract class FaspayConfigCredit
    {
        String merchantWindowUrl;
        String merchantDirectUrl;

        abstract public String getMerchantWindowUrl();

        abstract public String getMerchantDirectUrl();

        abstract public String getMerchantInquiryUrl();
        public FaspayConfigCredit()
        {
        }
    }
}
