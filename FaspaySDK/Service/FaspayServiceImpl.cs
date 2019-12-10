using System;
using System.Json;
using FaspayApi.Conf;
using FaspayApi.Entity;
using FaspayApi.Rest;
using FaspaySDK.Rest;
using Newtonsoft.Json;

namespace FaspayApi.Service
{
    public class FaspayServiceImpl : ApiServiceImpl, FaspayService
    {
        private UnregisteredErrorCallback mHandler;
        public FaspayServiceImpl(FaspayConfig mFaspayConfig) : base(mFaspayConfig)
        {

        }

        public void cancelTransaction(FaspayCancelPaymentRequest mRequest, FaspayCancelPaymentCallback mCallback)
        {
            this.mHandler = mCallback;
            String obj = JsonConvert.SerializeObject(mRequest);
            JsonObject o = (System.Json.JsonObject)JsonObject.Parse(obj);
            sendRequestHttpPost(mFaspayConfig.getCancelTransactionUrl(), o, new CancelTransactionCallback(mCallback));
        }

        public void createBilling(FaspayPaymentRequest mRequest, FaspayCreateBillingServiceCallback mCallback)
        {
            this.mHandler = mCallback; 
            String obj = JsonConvert.SerializeObject(mRequest);
            JsonObject o = (System.Json.JsonObject)JsonObject.Parse(obj);
            sendRequestHttpPost(mFaspayConfig.getCreateBillingUrl(), o, new CreateBillingCallback(mCallback));
        }

        public override UnregisteredErrorCallback getHandler()
        {
            return mHandler;
        }

        public void inqueryPaymentStatus(FaspayPaymentStatusRequest mRequest, FaspayInquiryPaymentStatusCallback mCallback)
        {
            this.mHandler = mCallback;
            String obj = JsonConvert.SerializeObject(mRequest);
            JsonObject o = (System.Json.JsonObject)JsonObject.Parse(obj);
            sendRequestHttpPost(mFaspayConfig.getInqueryPaymentStatusUrl(), o, new InquiryPaymentStatusCallback(mCallback));

        }

        public void inquiryPaymentChannel(FaspayInquiryServiceCallback mCallback)
        {
            this.mHandler = mCallback;
            JsonObject request = new JsonObject();
            request.Add("request", "");
            request.Add("merchant_id", mFaspayConfig.user.merchantId);
            request.Add("merchant", mFaspayConfig.user.merchantName);
            request.Add("signature", mFaspayConfig.user.calculateSignature());
            sendRequestHttpPost(mFaspayConfig.getInquiryPaymentChannelUrl(), request, new InquiryPCCallback(mCallback));
        }
        class InquiryPaymentStatusCallback : Callback
        {
            public InquiryPaymentStatusCallback(FaspayInquiryPaymentStatusCallback mCallback)
            {
                this.mCallback = mCallback;
            }
            FaspayInquiryPaymentStatusCallback mCallback;

            public void onFailure(Exception e)
            {
                if (mCallback != null)
                {
                    mCallback.onErrorGetInquiryPaymentStatusResponse(e);

                }
            }

            public void onResponse(JsonObject o1)
            {
                if (mCallback != null)
                {
                
                    FaspayPaymentStatusResponse mF = JsonConvert.DeserializeObject<FaspayPaymentStatusResponse>(
                        o1.ToString());
                    mCallback.onGetInquiryPaymentStatusResponse(mF);
                }
            }
        }
        class CancelTransactionCallback : Callback
        {
            FaspayCancelPaymentCallback mCallback;

            public CancelTransactionCallback(FaspayCancelPaymentCallback mCallback)
            {
                this.mCallback = mCallback;
            }

            public void onFailure(Exception e)
            {
                if (mCallback != null)
                {
                    mCallback.onErrorRequstCancelPayment(e);
                }

            }

            public void onResponse(JsonObject o1)
            {
                if (mCallback != null)
                {
                    FaspayCancelPaymentResponse mR = JsonConvert.DeserializeObject<FaspayCancelPaymentResponse>(
                        o1.ToString());
                    mCallback.onCancelPaymentSuccess(mR);
                }
            }
        }
        class CreateBillingCallback : Callback
        {
            public CreateBillingCallback(FaspayCreateBillingServiceCallback mCallback)
            {
                this.mCallback = mCallback;
            }
            FaspayCreateBillingServiceCallback mCallback;


            public void onFailure(Exception e)
            {
                if (mCallback != null)
                {
                    mCallback.onErrorGetPaymentResponse(e);
                }
            }

            public void onResponse(JsonObject o1)
            {

                if (mCallback != null)
                {
                    FaspayPaymentResponse r = JsonConvert.DeserializeObject<FaspayPaymentResponse>(o1.ToString());
                    mCallback.onGetPaymentResponse(r);
                }
                throw new NotImplementedException();
            }
        }
        class InquiryPCCallback : Callback
        {
            FaspayInquiryServiceCallback mCallback;
            public InquiryPCCallback(FaspayInquiryServiceCallback mCallback)
            {
                this.mCallback = mCallback;
            }
            public void onFailure(Exception e)
            {
                if (mCallback != null)
                {
                    mCallback.onErrorGetPaymentChannel(e);
                }
            }

            public void onResponse(JsonObject o1)
            {
                try
                {
                    FaspayPaymentChannelResponse r = JsonConvert.DeserializeObject<FaspayPaymentChannelResponse>(o1.ToString());
                    if (mCallback != null)
                    {
                        mCallback.onGetPaymentChannel(r);
                    }

                }
                catch (Exception e)
                {
                    if (mCallback != null)
                    {
                        mCallback.onErrorGetPaymentChannel(e);
                    }

                }
            }
        }
    }
}
