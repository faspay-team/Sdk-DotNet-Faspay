using System;
using System.Text;
using FaspayApi.Conf;
using FaspayApi.Utils;

namespace FaspayApi.Entity
{
    public class FaspayPaymentStatusRequestWrapper : FaspayPaymentStatusRequest
    {
        public FaspayPaymentStatusRequestWrapper(string request, String trxId, String bill_no, FaspayConfig mFaspayConfig)
        {
            String userAndPass = new StringBuilder(mFaspayConfig.user.userId).Append(mFaspayConfig.user.password).Append(bill_no).ToString();
            base.request = request;
            base.trx_id = trxId;
            base.bill_no = bill_no;
            base.merchant_id = mFaspayConfig.user.merchantId;
            base.signature = DiggestUtils.sha1(DiggestUtils.md5(userAndPass));
        }
    }
}
