using System;
using System.Text;
using FaspayApi.Utils;
using FaspaySDK.Credit.Conf;

namespace FaspaySDK.Credit.Entity.Payment.Wrapper
{
    public class FaspayPaymentCreditTransactionData
    {
        public   String merchant_tranid;
        public   String currencycode;
        public   long amount;
        public   FaspayUserCredit usr;
        public   String signature;

        public FaspayPaymentCreditTransactionData(FaspayUserCredit usr, String merchant_tranid, String currencycode, long amount)
        {
            this.usr = usr;
            this.merchant_tranid = merchant_tranid;
            this.currencycode = currencycode;
            this.amount = amount;
        }

        public String getMerchant_tranid()
        {
            return merchant_tranid;
        }

        public void setMerchant_tranid(String merchant_tranid)
        {
            this.merchant_tranid = merchant_tranid;
        }

        public String getSignature()
        {
            StringBuilder sb = new StringBuilder();


            signature = sb.Append("##").Append(usr.getMerchantId().ToUpper()).Append("##").Append(usr.getPass().ToUpper()).Append("##").Append(getMerchant_tranid()).Append("##").Append((getAmount().ToString("0.00"))).Append("##0##").ToString();

            return DiggestUtils.sha1(signature);
        }

        public void setSignature(String signature)
        {

        }

        public long getAmount()
        {
            return amount;
        }

        public void setAmount(long amount)
        {
            this.amount = amount;
        }

        public String getCurrencycode()
        {
            return currencycode;
        }

        public void setCurrencycode(String currencycode)
        {
            this.currencycode = currencycode;
        }

    }
}
