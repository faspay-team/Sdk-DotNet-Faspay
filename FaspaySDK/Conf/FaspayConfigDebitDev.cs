using System;
namespace FaspayApi.Conf
{
    public class FaspayConfigDebitDev : FaspayConfig

    {
        public FaspayConfigDebitDev(FaspayUser mFaspayUser) : base(mFaspayUser)

        {

        }

        public override string getInquiryPaymentChannelUrl()
        {
            return "https://dev.faspay.co.id/cvr/100001/10";
        }


        public override string getCreateBillingUrl()
        {
            return "https://dev.faspay.co.id/cvr/300011/10";
        }


        public override string getInqueryPaymentStatusUrl()
        {
            return "https://dev.faspay.co.id/cvr/100004/10";
        }


        public override string getCancelTransactionUrl()
        {
            return "https://dev.faspay.co.id/cvr/100005/10";
        }
    }
}
