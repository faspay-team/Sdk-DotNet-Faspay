using System;
namespace FaspayApi.Entity
{
    public class FaspayPayment
    {
        public const String PAYMENT_PLAN_FULL_SETTLEMENT = "1";
        public const String PAYMENT_PLAN_INSTALLMENT = "2";
        public const String TENOR_FULL = "00";
        public const String TENOR_3MONTHS = "03";
        public const String TENOR_6MONTHS = "06";
        public const String TENOR_12MONTHS = "12";
        public string product { get; set; }
        public string qty { get; set; }
        public string amount { get; set; }
        public string payment_plan { get; set; }
        public string merchant_id { get; set; }
        public string tenor { get; set; }
        public FaspayPayment()
        {
        }
        public FaspayPayment(String product, int qty, long amount, String paymentPlan, String merchantId, String tenor)
        {
            this.product = product;
            this.qty = qty.ToString();
            this.amount = amount.ToString();
            this.payment_plan = paymentPlan;
            this.merchant_id = merchantId;
            this.tenor = tenor;
        }
    }
}
