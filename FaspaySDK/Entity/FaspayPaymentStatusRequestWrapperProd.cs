using System;
using System.Text;
using FaspayApi.Conf;
using FaspayApi.Utils;

namespace FaspayApi.Entity
{
    public class FaspayPaymentStatusRequestWrapperProd : FaspayPaymentStatusRequest
    {

        public String payment_status_desc { get; set; }
        public String payment_status_code { get; set; }

        public FaspayPaymentStatusRequestWrapperProd(string request, String trxId, String bill_no, FaspayConfig mFaspayConfig, String payment_status_desc, String payment_status_code)
        {
            String userAndPass = new StringBuilder(mFaspayConfig.user.userId).Append(mFaspayConfig.user.password).Append(bill_no).ToString();
            base.request = request;
            base.trx_id = trxId;
            base.bill_no = bill_no;
            this.payment_status_code = payment_status_code;
            this.payment_status_desc = payment_status_desc;
            base.merchant_id = mFaspayConfig.user.merchantId;
            base.signature = DiggestUtils.sha1(DiggestUtils.md5(userAndPass));
        }
    }
}
