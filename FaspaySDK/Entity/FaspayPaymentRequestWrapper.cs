using System;
using System.Text;
using FaspayApi.Conf;
using FaspayApi.Utils;

namespace FaspayApi.Entity
{
    public class FaspayPaymentRequestWrapper : FaspayPaymentRequest
    {
        public const int PAY_TYPE_PAY_TYPE_FULL_SETTLEMENT = 1;
        public const int PAY_TYPE_INSTALLMENT = 2;
        public const int PAY_TYPE_MIXED = 3;

        public const int TERMINAL_WEB = 10;
        public const int TERMINAL_MOBILE_APP_BLACKBERRY = 20;
        public const int TERMINAL_MOBILE_APP_ANDROID = 21;
        public const int TERMINAL_MOBILE_APP_IOS = 22;
        public const int TERMINAL_MOBILE_APP_WINDOWS = 23;
        public const int TERMINAL_MOBILE_APP_SYMBIAN = 24;
        public const int TERMINAL_TAB_APP_BLACKBERRY = 30;
        public const int TERMINAL_TAB_APP_ANDROID = 31;
        public const int TERMINAL_TAB_APP_IOS = 32;
        public const int TERMINAL_TAB_APP_WINDOWS = 33;

        public FaspayPaymentRequestWrapper(
            FaspayConfig mFaspayConfig,
            FaspayPaymentRequestBillData billing,
            FaspayPaymentChannel mFaspayPaymentChannel,
            FaspayPaymentRequestUserData userData,
            FaspayPaymentRequestShippingData mShippingData
            )
        {


            merchant_id = (mFaspayConfig.user.merchantId);
            merchant = (mFaspayConfig.user.merchantName);
            bill_no = (billing.bill_no);
            bill_reff = (billing.bill_reff);
            bill_date = (billing.bill_date);
            bill_expired = (billing.bill_expired);
            bill_desc = (billing.bill_expired);
            bill_currency = (billing.bill_currency);
            bill_gross = (billing.bill_gross);

            bill_miscfee = (billing.bill_miscfee);

            bill_total = (billing.bill_total);
            cust_no = (userData.custNo);
            cust_name = (userData.custName);
            payment_channel = (mFaspayPaymentChannel.pg_code);
            bank_userid = (userData.bank_userid);
            msisdn = (userData.msisdn);
            email = (userData.email);
            terminal = (userData.terminal);
            billing_name = (billing.billing_name);
            billing_lastname = (billing.billing_lastname);
            billing_address = (billing.billing_address);
            billing_address_city = (billing.billing_address_city);
            billing_address_region = (billing.billing_address_region);
            billing_address_state = (billing.billing_address_state);
            billing_address_poscode = (billing.billing_address_poscode);
            billing_msisdn = (billing.billing_msisdn);
            billing_address_country_code = (billing.billing_address_country_code);
            receiver_name_for_shipping = (mShippingData.receiver_name_for_shipping);
            shipping_lastname = (mShippingData.shipping_lastname);
            shipping_address = (mShippingData.shipping_address);
            shipping_address_city = (mShippingData.shipping_address_city);
            shipping_address_region = (mShippingData.shipping_address_region );
            shipping_address_state = (mShippingData.shipping_address_state);
            shipping_address_poscode = (mShippingData.shipping_address_poscode);
            shipping_msisdn = (mShippingData.shipping_msisdn);
            shipping_address_country_code = (mShippingData.shipping_address_country_code);
            item = (billing.item);
            reserve1 = ("");
            reserve2 = ("");
            request = ("");
            pay_type = billing.pay_type;

            String userAndPass = new StringBuilder(mFaspayConfig.user.userId).Append(mFaspayConfig.user.password).Append(bill_no).ToString();

            signature = (DiggestUtils.sha1(DiggestUtils.md5(userAndPass)));


        }
    }
}
