using System;
using System.Collections.Generic;
using FaspayApi.Entity;
using FaspaySDK.Rest;

namespace FaspayApi.Service
{
    public interface FaspayService
    {
        void inquiryPaymentChannel(FaspayInquiryServiceCallback mCallback);
        void createBilling(FaspayPaymentRequest mFaspayPaymentRequest, FaspayCreateBillingServiceCallback mCallback);
        void inqueryPaymentStatus(FaspayPaymentStatusRequest mRequest, FaspayInquiryPaymentStatusCallback mCallback);
        void cancelTransaction(FaspayCancelPaymentRequest mFaspayCancelPaymentRequest, FaspayCancelPaymentCallback mCallback);


    }
    public interface FaspayInquiryServiceCallback:UnregisteredErrorCallback

    {

        void onGetPaymentChannel(FaspayPaymentChannelResponse channel);

        void onErrorGetPaymentChannel(Exception e);
    }

    public interface FaspayCreateBillingServiceCallback : UnregisteredErrorCallback
    {

        void onGetPaymentResponse(FaspayPaymentResponse channel);

        void onErrorGetPaymentResponse(Exception e);
    }

    public interface FaspayInquiryPaymentStatusCallback : UnregisteredErrorCallback
    {

        void onGetInquiryPaymentStatusResponse(FaspayPaymentStatusResponse channel);

        void onErrorGetInquiryPaymentStatusResponse(Exception e);
    }

    public interface FaspayCancelPaymentCallback : UnregisteredErrorCallback
    {

        void onCancelPaymentSuccess(FaspayCancelPaymentResponse channel);

        void onErrorRequstCancelPayment(Exception e);
    }
}
