using System;
using System.Text;
using FaspayApi.Utils;
using FaspaySDK.Credit.Conf;

namespace FaspaySDK.Credit.Entity.Refund
{
    public class RefundRequestWrapperProd:RefundRequest
    {
        public RefundRequestWrapperProd()
        {
        }

        public RefundRequestWrapperProd(FaspayUserCredit user, String MERCHANT_TRANID, String TRANSACTIONID, long AMOUNT, String CUSTNAME, String CUSTEMAIL, String DESCRIPTION, String RETURN_URL, long REFUND_AMOUNT)
        {
            this.merchantid = user.getMerchantId();
            this.merchant_tranid = MERCHANT_TRANID;
            this.transactionid = TRANSACTIONID;

            this.amount = AMOUNT.ToString("0.00");
            this.refund_amount = REFUND_AMOUNT.ToString("0.00");
            this.custname = CUSTNAME;
            this.custemail = CUSTEMAIL;
            this.description = DESCRIPTION;
            this.return_url = RETURN_URL;
            String raw = new StringBuilder().Append("##").Append(user.getMerchantId().ToUpper()).Append("##").Append(user.getPass().ToUpper()).Append("##").Append(merchant_tranid).Append("##").Append(getAmount()).Append("##").Append(TRANSACTIONID).Append("##").ToString();

            this.signature = DiggestUtils.sha1(raw);
        }


        public override string getUrl()
        {
            return "https://fpg.faspay.co.id/payment/api";
        }
    }
}
