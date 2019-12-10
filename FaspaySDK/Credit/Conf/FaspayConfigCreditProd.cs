using System;
using FaspaySDK.Credit.Conf;

namespace FaspaySDK
{
    public class FaspayConfigCreditProd : FaspayConfigCredit

    {
        public FaspayConfigCreditProd()
        {
        }




        public override string getMerchantWindowUrl()
        {
            return "https://fpg.faspay.co.id/payment";
        }

        public override string getMerchantDirectUrl()
        {
            return "https://fpg.faspay.co.id/payment";
        }

        public override string getMerchantInquiryUrl()
        {
            return "https://fpg.faspay.co.id/payment/api";
        }
    }
}
