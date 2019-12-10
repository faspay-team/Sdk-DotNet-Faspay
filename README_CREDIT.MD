# Faspay SDK CREDIT

this SDK 


for import

```php
using System;
using System.Collections.Generic;
using FaspayApi.Conf;
using FaspayApi.Entity;
using FaspayApi.Service;
using FaspaySDK;
using Newtonsoft.Json;
using FaspaySDK.Credit.Conf;
using FaspaySDK.Credit.Entity.Payment;
using FaspaySDK.Credit.Entity.Payment.Wrapper;
using FaspaySDK.Entity.Err;
using System.IO;
using FaspaySDK.Credit.Entity.Capture;
using FaspaySDK.Credit.Entity.Inquiry;
using FaspaySDK.Credit.Entity.Refund;

using System.Xml;
using System.Xml.Serialization;
using FaspaySDK.Credit.Entity.Void;
using FaspaySDK.Entity.Notify;
```



# User Object

just like debit payment, this SDK needs user object, 

```c#
FaspayUser user = new FaspayUser("FASPAY", "99999", "bot99999", "p@ssw0rd", "https://faspay.co.id/merchantpage/billing/process/thankyou");
FaspayConfig config = new FaspayConfigDebitProd(user);
FaspayService service = new FaspayServiceImpl(config);

}

```



# Faspay Credit Create Payment

just like debit function, this function create the payment but user must fill the form of html 

```c#
//sample code
//create the items first
var w = new FaspayPaymentCreditWrapperProd(usr,
new FaspayPaymentCreditTransactionData(usr, Guid.NewGuid().ToString().Replace("-", ""), "IDR", 10000),
new FaspayPaymentCreditShopperData("ha", "ha@ha.com",
"123123123123", "123123", "5123456789012346", "123123",
FaspayPaymentCredit.CARD_TYPE_VISA, 10, "2020", "123123"),
new FaspayPaymentCreditConfigApp(FaspayPaymentCredit.RESPONSE_TYPE_POST, "http://<<URL NOTIFY>>"),
new FaspayPaymentCreditBillData("123", "123", "123", "123", "123", "ID"),
new FaspayPaymentCreditShippingdata("5", "5", "5", "5", "5", "5", 0),
new FaspayPaymentCreditItemData("Item #1","Item #2","Item #3"),
new FaspayPaymentCreditDomicileData(),
new FaspayPaymentCreditCardData());


```

save the html and open it, or display in app

```c#
StreamWriter d = new StreamWriter(pathHtml);
d.WriteLine(w.generateHtml());
d.Flush();
d.Close();
Console.WriteLine(w.generateHtml());
//open html 
```


# capture payment

```c#
CaptureRequestWrapperDev x = new CaptureRequestWrapperDev(new TetsUser2(), "5a49f6787ae2405d9be2733fb2f46b82", "315F1D29-3760-46FB-9406-6D1EC3C38B03", 100000, "merhcant test CC", "haha@haha.com", "ddddd ", "<< URL CALLBACK >>");
String html = x.generateHtml();
StreamWriter d = new StreamWriter(pathHtml);
d.WriteLine(html);
d.Flush();
d.Close();
```

# inquiry payment

```c#
FaspayConfigCredit conf = new FaspayConfigCreditDev();
FaspayUserCredit credit = new TetsUser2();

InquiryRequestCredit e = new InquiryRequestCreditWrapper(conf, credit, "2ccb26d48b6c428ba8ba69cdb5558197", 100000);
StreamWriter d = new StreamWriter(pathHtml);
d.WriteLine(e.generateHtml());
d.Flush();
d.Close();
```

# Refund payment



```c#
String html = new RefundRequestWrapperDev(new TetsUser2(), "d5868d24410a4238ab9938f8527c83f7", "35124DAD-BD95-4B6E-9B71-6C8B45BC5147", 100000, "merhcant test CC", "haha@haha.com", "ddddd ", "<<URL NOTIFY>>", 10000).generateHtml();
StreamWriter d = new StreamWriter(pathHtml);
d.WriteLine(html);
d.Flush();
d.Close();
```

# Void payment


wrap it up
```c#
String html = new VoidRequestWrapperDev(new TetsUser2(), "5a49f6787ae2405d9be2733fb2f46b82", "315F1D29-3760-46FB-9406-6D1EC3C38B03", 100000, "merhcant test CC", "haha@haha.com", "ddddd ", "<<URL NOTIFY>>").generateHtml();
StreamWriter d = new StreamWriter(pathHtml);
d.WriteLine(html);
d.Flush();
d.Close();
```
