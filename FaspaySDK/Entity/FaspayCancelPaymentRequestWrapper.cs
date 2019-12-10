using System;
using System.Text;
using FaspayApi.Conf;
using FaspayApi.Utils;

namespace FaspayApi.Entity
{
    public class FaspayCancelPaymentRequestWrapper : FaspayCancelPaymentRequest
    {
        public string request { get; set; }
        public string trx_id { get; set; }
        public string merchant_id { get; set; }
        public string merchant { get; set; }
        public string bill_no { get; set; }
        public string payment_cancel { get; set; }
        public string signature { get; set; }
        public FaspayCancelPaymentRequestWrapper()
        {
        }
        public FaspayCancelPaymentRequestWrapper(String trxId, String merchantId, String merchant, String billNo, String paymentCancel)
        {
            this.trx_id = trxId;
            this.merchant_id = merchantId;
            this.merchant = merchant;
            this.bill_no = billNo;
            this.payment_cancel = paymentCancel;
        }


        public FaspayCancelPaymentRequestWrapper(String trxId, String billNo, String paymentCancel, FaspayConfig mFaspayConfig)
        {
            this.trx_id = trxId;
            this.bill_no = billNo;
            this.payment_cancel = paymentCancel;
            this.merchant = mFaspayConfig.user.merchantName;
            this.merchant_id = mFaspayConfig.user.merchantId;

            String userAndPass = new StringBuilder(mFaspayConfig.user.userId).Append(mFaspayConfig.user.password).Append(billNo).ToString();

            this.signature = DiggestUtils.sha1(DiggestUtils.md5(userAndPass));
        }


    }
}
