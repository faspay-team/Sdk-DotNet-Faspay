# Faspay SDK




Sdk for developing faspay API for PHP


this sdk contains 2 parts of payment ,debit and credit, debit mostly use POST Rest API with json, all objects are wrapped
for faspay credit - __[click here ](https://github.com/hilmanshini/Faspay_Dotnet/blob/master/README_CREDIT.MD)__ - 


for faspay debit you can follow docs below 
# Faspay Debit

to begin, you must extends the configurations and class like below and create the service


```c#
FaspayUser user = new FaspayUser("FASPAY", "99999", "bot99999", "p@ssw0rd", "https://faspay.co.id/merchantpage/billing/process/thankyou");
FaspayConfig config = new FaspayConfigDebitProd(user);
FaspayService service = new FaspayServiceImpl(config);
```
to get payment gateway list of your user

```c#
class PCCAllback : FaspayInquiryServiceCallback

{

    public void onErrorGetPaymentChannel(Exception e)
    {
    Console.WriteLine("Error " + e.Message);
    }

    public void onGetPaymentChannel(FaspayPaymentChannelResponse channel)
    {
    Console.WriteLine(channel.response_code);
    Console.WriteLine(channel.payment_channel.Count);
    }

    public void onUserNotRegistered(UnregisteredError mUnregisteredError)
    {
    Console.WriteLine("UNREG");
    //throw new NotImplementedException();
    }
}
service.inquiryPaymentChannel(new PCCAllback());
```

# Faspay Create Payment Debit
```c#
class TestCreateBillingCallback : FaspayCreateBillingServiceCallback

        {
        public void onErrorGetPaymentResponse(Exception e)
        {

        }

        public void onGetPaymentResponse(FaspayPaymentResponse channel)
        {

        }

        public void onUserNotRegistered(UnregisteredError mUnregisteredError)
        {

        }
}
List<FaspayPayment> item = new List<FaspayPayment>();
item.Add(new FaspayPayment("Item 1", 1, 100000, FaspayPayment.PAYMENT_PLAN_FULL_SETTLEMENT, config.user.merchantId, FaspayPayment.TENOR_FULL));
item.Add(new FaspayPayment("Item 2", 1, 100000, FaspayPayment.PAYMENT_PLAN_FULL_SETTLEMENT, config.user.merchantId, FaspayPayment.TENOR_FULL));                 item.Add(new FaspayPayment("test 1", 1, 100000, FaspayPayment.PAYMENT_PLAN_FULL_SETTLEMENT, config.user.merchantId, FaspayPayment.TENOR_FULL));
item.Add(new FaspayPayment("Item 3", 1, 100000, FaspayPayment.PAYMENT_PLAN_FULL_SETTLEMENT, config.user.merchantId, FaspayPayment.TENOR_FULL)); item.Add(new FaspayPayment("test 1", 1, 100000, FaspayPayment.PAYMENT_PLAN_FULL_SETTLEMENT, config.user.merchantId, FaspayPayment.TENOR_FULL));


FaspayPaymentRequestBillData billing = new FaspayPaymentRequestBillData("123123", "x", 10, "10000", item, FaspayPaymentRequestWrapper.PAY_TYPE_INSTALLMENT);
FaspayPaymentRequestUserData mFaspayPaymentRequestUserData = new FaspayPaymentRequestUserData("087123123123", "hil@hil.com", (FaspayPaymentRequestWrapper.TERMINAL_MOBILE_APP_ANDROID).ToString(), "123123", "123123");
FaspayPaymentRequestShippingData mFaspayPaymentRequestShippingData = new FaspayPaymentRequestShippingData();
FaspayPaymentRequestWrapper mFaspayPaymentRequestWrapper = new FaspayPaymentRequestWrapper(config, billing, mFaspayPaymentChannel, mFaspayPaymentRequestUserData, mFaspayPaymentRequestShippingData);
service.createBilling(mFaspayPaymentRequestWrapper, new TestCreateBillingCallback());


```



# Faspay Debit, cancel payment



to cancel payment 
```c#
class FaspayCancelCallback : FaspayCancelPaymentCallback
{
            public void onCancelPaymentSuccess(FaspayCancelPaymentResponse channel)
            {

            }

            public void onErrorRequstCancelPayment(Exception e)
            {

            }

            public void onUserNotRegistered(UnregisteredError mUnregisteredError)
            {

            }
}
            service.cancelTransaction(new FaspayCancelPaymentRequestWrapper("8986322540000760", "123123", "gatau", config), new FaspayCancelCallback());
```

# Faspay Debit, inquiry payment

to inquiry the status of payment

```c#

class FaspayInqueryPaymentStatus : FaspayInquiryPaymentStatusCallback
{
        public void onErrorGetInquiryPaymentStatusResponse(Exception e)
        {

        }

        public void onGetInquiryPaymentStatusResponse(FaspayPaymentStatusResponse channel)
        {

        }

        public void onUserNotRegistered(UnregisteredError mUnregisteredError)
        {

        }
}
            service.inqueryPaymentStatus(new FaspayPaymentStatusRequestWrapperProd("x", "8986322540001750", "7877811", config, "12313123", "0"), new FaspayInqueryPaymentStatus());
```


# IMPORTANT! Faspay Payment Notification
when users accept payment or cancel payment the notification of payment status are sent to your server , Contact faspay support to register your callback url notification, 

your callback controller from your http server  must response the request from faspay in the format that suits faspay needs , 
the format could be generated with this code in your controller



```c#

new NotifyHandler().handle(xml);
```
