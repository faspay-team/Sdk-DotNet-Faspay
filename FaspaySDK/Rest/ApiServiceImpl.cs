using System;
using System.Collections;
using System.Json;
using RestSharp;
using JsonObject = System.Json.JsonObject;
using System.Collections.Generic;
using FaspayApi.Conf;
using FaspaySDK.Rest;
using FaspaySDK.Entity.Err;
using Newtonsoft.Json;

namespace FaspayApi.Rest
{
    public abstract class ApiServiceImpl : ApiService

    {
        public FaspayConfig mFaspayConfig { get; set; }
        public ApiServiceImpl(FaspayConfig mFaspayConfig)
        {
            this.mFaspayConfig = mFaspayConfig;
        }
        public abstract UnregisteredErrorCallback getHandler();
        public void sendRequestHttpPost(string url, JsonObject mJsonObject, Dictionary<String, String> headers, Callback mCallbackPost)
        {
            var client = new RestClient(url);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            Console.Write("URL? " + url);
            var request = new RestRequest();
            Console.WriteLine("sending " + mJsonObject.ToString());
            request.AddJsonBody(mJsonObject.ToString());
            client.PostAsync(request, (IRestResponse arg1, RestRequestAsyncHandle arg2) =>
            {

                var o = JsonObject.Parse(arg1.Content);
                if (mCallbackPost != null)
                {
                    JsonObject obj = (System.Json.JsonObject)o;
                    Console.WriteLine("received2 " + obj.ToString());
                    if (handleUnregistered(obj, getHandler(), mCallbackPost ))
                    {
                        return;
                    } else
                    {
                        Console.WriteLine("Handle normally");
                        mCallbackPost.onResponse(obj);
                    }

                }
            });

        }

        public void sendRequestHttpPost(string url, JsonObject mJsonObject, Callback mCallbackPost)
        {
            sendRequestHttpPost(url, mJsonObject, new Dictionary<String, String>(), mCallbackPost);

        }
        protected Boolean handleUnregistered(JsonObject t, UnregisteredErrorCallback mCallback, Callback mCallbackPost)
        {

            if (t.ContainsKey("response_error"))
            {



                JsonObject er = (System.Json.JsonObject)t["response_error"];
                Console.WriteLine("Contains resp error" + er["response_code"].Equals("40")
                    );


                if (Int32.Parse(er["response_code"]) == 40)
                {
                    Console.WriteLine("COntains 40");

                    Console.WriteLine("Unregister");
                    try
                    {
                        UnregisteredError e = JsonConvert.DeserializeObject<UnregisteredError>(
                        t.ToString());
                        mCallback.onUserNotRegistered(e);
                     //   Console.WriteLine("UNREG");
                        return true;
                    }
                    catch (Exception e)
                    {
                        mCallbackPost.onFailure(e);

                    }

                }

            }
            Console.WriteLine("Not Unregister");

            return false;
        }
    }
}
