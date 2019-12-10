using System;
namespace FaspayApi.Conf
{
    public class FaspayConfigDebitProd : FaspayConfig
    {
        public FaspayConfigDebitProd(FaspayUser mFaspayUser) : base(mFaspayUser)
        {
        }

        public override string getInquiryPaymentChannelUrl()
        {
            return "https://web.faspay.co.id/cvr/100001/10";
        }


        public override string getCreateBillingUrl()
        {
            return "https://web.faspay.co.id/cvr/300011/10";
        }


        public override string getInqueryPaymentStatusUrl()
        {
            return "https://web.faspay.co.id/cvr/100004/10";
        }


        public override string getCancelTransactionUrl()
        {
            return "https://web.faspay.co.id/cvr/100005/10";
        }
    }

}
