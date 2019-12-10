using System;
using System.Globalization;
using System.Text;
using FaspayApi.Utils;
using FaspaySDK.Credit.Conf;

namespace FaspaySDK.Credit.Entity.Inquiry
{
    public class InquiryRequestCreditWrapper:InquiryRequestCredit
    {
        FaspayUserCredit user;



        public InquiryRequestCreditWrapper(FaspayConfigCredit configCredit, FaspayUserCredit user, String MERCHANT_TRANID, long amount):base(configCredit)
        {
        
            this.user = user;

            this.merchant_tranid = MERCHANT_TRANID;
            this.amount = amount.ToString("0.00", CultureInfo.InvariantCulture);

            setTransactiontype("4");
            setResponse_type("3");
            setMerchantid(user.getMerchantId());
            setPayment_method("1");
            String rawsig = new StringBuilder("##").Append(user.getMerchantId().ToUpper()).Append("##").Append(user.getPass().ToUpper()).Append("##").Append(MERCHANT_TRANID).Append("##").Append(getAmount()).Append("##0##").ToString();
            this.signature = DiggestUtils.sha1(rawsig);
        }

        public FaspayUserCredit getUser()
        {
            return user;
        }

        public void setUser(FaspayUserCredit user)
        {
            this.user = user;
        }





    
    }
}
