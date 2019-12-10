using System;
using FaspaySDK.Credit.Conf;
using System;

using System.Json;
using System.Text;
using Newtonsoft.Json;
namespace FaspaySDK.Credit.Entity.Inquiry
{
    public class InquiryRequestCredit
    {
        public   String transactiontype;
        public   String response_type;
        public   String merchantid;
        public   String payment_method;
        public   String merchant_tranid;
        public   String signature;
        public   String amount;

        FaspayConfigCredit configCredit;


        public InquiryRequestCredit()
        {
        }




        public InquiryRequestCredit(FaspayConfigCredit configCredit)
        {
            this.configCredit = configCredit;
        }

        public void setTransactiontype(String transactiontype)
        {
            this.transactiontype = transactiontype;
        }


        public String getResponse_type()
        {
            return response_type;
        }

        public void setResponse_type(String response_type)
        {
            this.response_type = response_type;
        }

        public String getMerchantid()
        {
            return merchantid;
        }

        public void setMerchantid(String merchantid)
        {
            this.merchantid = merchantid;
        }

        public String getPayment_method()
        {
            return payment_method;
        }

        public void setPayment_method(String payment_method)
        {
            this.payment_method = payment_method;
        }

        public String getMerchant_tranid()
        {
            return merchant_tranid;
        }

        public void setMerchant_tranid(String merchant_tranid)
        {
            this.merchant_tranid = merchant_tranid;
        }



        public String getAmount()
        {
            return amount;
        }

        public void setAmount(String amount)
        {
            this.amount = amount;
        }

        public String getSignature()
        {
            return signature;
        }

        public void setSignature(String signature)
        {
            this.signature = signature;
        }


        public String getTransactiontype()
        {
            return transactiontype;
        }

        public String generateHtml()
        {


            JsonObject data = (System.Json.JsonObject)JsonValue.Parse(JsonConvert.SerializeObject(this));
            StringBuilder sb = new StringBuilder("<form method=\"post\" name=\"form\" action=\"" + configCredit.getMerchantInquiryUrl() + "\">");
            foreach (var x in data)
            {
                string name = x.Key;
                JsonValue value = x.Value;
                String val;
                if (value != null)
                {
                    val = value.ToString();

                }
                else
                {
                    val = "\"\"";
                }
                sb = sb.Append("\n");
                sb = sb.Append("<input type=\"hidden\" name=");
                sb = sb.Append(name.ToUpper());
                sb = sb.Append(" value=");
                sb = sb.Append(val);
                sb = sb.Append(">");
            }
            sb = sb.Append("\n</form>");
            sb = sb.Append("<script> document.form.submit();</script>");



            return sb.ToString();



        }
    }
}
