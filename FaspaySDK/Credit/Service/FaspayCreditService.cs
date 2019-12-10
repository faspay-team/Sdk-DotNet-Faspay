using System;
using FaspaySDK.Credit.Entity.Inquiry;
using FaspaySDK.Credit.Entity.Void;

namespace FaspaySDK.Credit.Service
{
    public interface FaspayCreditService
    {
        void inquiry(InquiryRequestCredit credit, InquiryPaymentCallback callback);



    }
    public interface InquiryPaymentCallback
    {

        void onErrorGetResponseInquiryPaymentCredit(Exception E);

         void onGetResponseInquiryPaymentCredit(InquiryResponseCredit clas);
    }


}
