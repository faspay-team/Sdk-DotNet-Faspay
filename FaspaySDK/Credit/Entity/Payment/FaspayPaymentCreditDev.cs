using System;
namespace FaspaySDK.Credit.Entity.Payment
{
    public class FaspayPaymentCreditDev : FaspayPaymentCredit

    {
        public FaspayPaymentCreditDev()
        {
        }

        public override string getUrl()
        {
            return "https://fpgdev.faspay.co.id/payment";
        }
    }
}
