using System;
namespace FaspaySDK.Credit.Entity.Payment
{
    public class FaspayPaymentCreditProd : FaspayPaymentCredit

    {
        protected String pymt_ind = "card_range_ind";
        protected String pymt_criteria = "credit_card";
        protected String pymt_token = "";
        public FaspayPaymentCreditProd()
        {
        }
        public String getPymt_token()
        {
            return pymt_token;
        }

        public void setPymt_token(String pymt_token)
        {
            this.pymt_token = pymt_token;
        }


        public String getPymt_ind()
        {
            return pymt_ind;
        }

        public void setPymt_ind(String pymt_ind)
        {
            this.pymt_ind = pymt_ind;
        }

        public String getPymt_criteria()
        {
            return pymt_criteria;
        }

        public void setPymt_criteria(String pymt_criteria)
        {
            this.pymt_criteria = pymt_criteria;
        }
        public override string getUrl()
        {
            return "https://fpg.faspay.co.id/payment";
        }

    }
}
