using System;
using FaspaySDK.Credit.Conf;

namespace FaspaySDK
{
    public class FaspayConfigCreditDev:FaspayConfigCredit
    {
        public FaspayConfigCreditDev()
        {
        }

        public override string getMerchantDirectUrl()
        {
            return "https://fpgdev.faspay.co.id/payment";

        }

        public override string getMerchantInquiryUrl()
        {
            return "https://fpgdev.faspay.co.id/payment/api";
        }

        public override string getMerchantWindowUrl()
        {
            return "https://fpgdev.faspay.co.id/payment";
        }
    }
}
