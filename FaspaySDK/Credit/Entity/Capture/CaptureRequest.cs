using System;

using System.Json;
using System.Text;
using Newtonsoft.Json;
namespace FaspaySDK.Credit.Entity.Capture
{
    public abstract class CaptureRequest
    {
        public CaptureRequest()
        {
        }

        public   String transactiontype = "2";
        public   String response_type = "3";
        public   String merchantid;
        public   String payment_method = "1";
        public   String merchant_tranid;
        public   String transactionid;
        public   String amount;
        public   String custname;
        public   String custemail;
        public   String description;
        public   String return_url;
        public   String signature;

        public String getTransactiontype()
        {
            return transactiontype;
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

        public String getTransactionid()
        {
            return transactionid;
        }

        public void setTransactionid(String transactionid)
        {
            this.transactionid = transactionid;
        }

        public String getAmount()
        {
            return amount;
        }

        public void setAmount(String amount)
        {
            this.amount = amount;
        }

        public String getCustname()
        {
            return custname;
        }

        public void setCustname(String custname)
        {
            this.custname = custname;
        }

        public String getCustemail()
        {
            return custemail;
        }

        public void setCustemail(String custemail)
        {
            this.custemail = custemail;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getReturn_url()
        {
            return return_url;
        }

        public void setReturn_url(String return_url)
        {
            this.return_url = return_url;
        }

        public String getSignature()
        {
            return signature;
        }

        public void setSignature(String signature)
        {
            this.signature = signature;
        }


        public abstract String getUrl();


        public String generateHtml()
        {
            JsonObject data = (System.Json.JsonObject)JsonValue.Parse(JsonConvert.SerializeObject(this));
            StringBuilder sb = new StringBuilder("<form method=\"post\" name=\"form\" action=\"" + getUrl() + "\">");
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
