
using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FaspayApi.Rest;
using System.Json;
using Newtonsoft.Json;
using FaspayApi.Entity;
using FaspayApi.Conf;
using FaspayApi.Service;
using System.Collections.Generic;
using FaspaySDK.Entity.Err;

namespace FaspayApi
{
    class Program
    {
        static void Main(string[] args)
        {

            test();
        }
        static void test()
        {

            FaspayUser user = new FaspayUserTest();
            FaspayConfig config = new FaspayConfigDebitDev(user);

            new FaspayServiceImpl(config).inquiryPaymentChannel(new TestCallback());


            FaspayPaymentChannel mFaspayPaymentChannel = new FaspayPaymentChannel();
            mFaspayPaymentChannel.pg_code = ("402");
            mFaspayPaymentChannel.pg_name = ("ALFA");
            List<FaspayPayment> item = new List<FaspayPayment>();
            item.Add(new FaspayPayment("anjing edan", 1, 100000, FaspayPayment.PAYMENT_PLAN_FULL_SETTLEMENT, config.user.merchantId, FaspayPayment.TENOR_FULL));
            FaspayPaymentRequestBillData billing = new FaspayPaymentRequestBillData("123123", "x", 10, "10000", item,FaspayPaymentRequestWrapper.PAY_TYPE_INSTALLMENT);
            FaspayPaymentRequestUserData mFaspayPaymentRequestUserData = new FaspayPaymentRequestUserData("087123123123", "hil@hil.com", (FaspayPaymentRequestWrapper.TERMINAL_MOBILE_APP_ANDROID).ToString(), "123123", "hahahaha");
            FaspayPaymentRequestShippingData mFaspayPaymentRequestShippingData = new FaspayPaymentRequestShippingData();
            FaspayPaymentRequestWrapper mFaspayPaymentRequestWrapper = new FaspayPaymentRequestWrapper(config, billing, mFaspayPaymentChannel, mFaspayPaymentRequestUserData, mFaspayPaymentRequestShippingData);
            new FaspayServiceImpl(config).createBilling(mFaspayPaymentRequestWrapper,new TestCreateBillingCallback());
            Console.ReadKey();

        }
        class TestCreateBillingCallback : FaspayCreateBillingServiceCallback
        {
            public void onErrorGetPaymentResponse(Exception e)
            {
                //e.StackTrace;
            }

            public void onGetPaymentResponse(FaspayPaymentResponse channel)
            {
                Console.WriteLine(channel.bill_no);
            }

            public void onUserNotRegistered(UnregisteredError mUnregisteredError)
            {
                throw new NotImplementedException();
            }
        }
        class TestCallback : FaspayInquiryServiceCallback
        {
            public void onErrorGetPaymentChannel(Exception e)
            {
                throw new NotImplementedException();
            }

            public void onGetPaymentChannel(FaspayPaymentChannelResponse channel)
            {
                throw new NotImplementedException();
            }

            public void onUserNotRegistered(UnregisteredError mUnregisteredError)
            {
                throw new NotImplementedException();
            }
        }
    }
}
