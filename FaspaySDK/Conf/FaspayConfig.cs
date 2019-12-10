using System;
namespace FaspayApi.Conf
{
    public abstract class FaspayConfig
    {
        public FaspayUser user { get; private set; }
        public FaspayConfig(FaspayUser mFaspayUser)
        {
            this.user = mFaspayUser;
        }

        public abstract String getInquiryPaymentChannelUrl();

        public abstract String getCreateBillingUrl();

        public abstract String getInqueryPaymentStatusUrl();

        public abstract String getCancelTransactionUrl();
    }
}
