using System;
using System.Xml;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace FaspaySDK.Entity.Notify
{
    [XmlRoot("faspay")]
    public class FaspayTraceSuccessXMLResponse
    {
        public String response = "Payment Notification";
        public String trx_id;
        public String merchant_id;
        public String bill_no;
        public String response_code = "00";
        public String response_desc = "Success";
        public String response_date;

        public FaspayTraceSuccessXMLResponse(String trx_id, String merchant_id, String bill_no)
        {
            this.trx_id = trx_id;
            this.merchant_id = merchant_id;
            this.bill_no = bill_no;


            response_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public FaspayTraceSuccessXMLResponse()
        {

        }
        public FaspayTraceSuccessXMLResponse(FaspayNotifyResponse response)
        {
            this.trx_id = response.getTrx_id();
            this.merchant_id = response.getMerchant_id();
            this.bill_no = response.getBill_no();

            response_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        public String getResponse()
        {
            return response;
        }

        public void setResponse(String response)
        {
            this.response = response;
        }

        public String getTrx_id()
        {
            return trx_id;
        }

        public void setTrx_id(String trx_id)
        {
            this.trx_id = trx_id;
        }

        public String getMerchant_id()
        {
            return merchant_id;
        }

        public void setMerchant_id(String merchant_id)
        {
            this.merchant_id = merchant_id;
        }

        public String getBill_no()
        {
            return bill_no;
        }

        public void setBill_no(String bill_no)
        {
            this.bill_no = bill_no;
        }

        public String getResponse_code()
        {
            return response_code;
        }

        public void setResponse_code(String response_code)
        {
            this.response_code = response_code;
        }

        public String getResponse_desc()
        {
            return response_desc;
        }

        public void setResponse_desc(String response_desc)
        {
            this.response_desc = response_desc;
        }

        public String getResponse_date()
        {
            return response_date;
        }

        public void setResponse_date(String response_date)
        {
            this.response_date = response_date;
        }
    }
}
