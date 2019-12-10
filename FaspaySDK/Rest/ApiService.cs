using System;
using System.Json;
using System.Collections;
using System.Collections.Generic;
namespace FaspayApi.Rest
{
    public interface ApiService
    {
        void sendRequestHttpPost(String url, JsonObject mJsonObject, Dictionary<String, String> headers, Callback mCallbackPost);
        void sendRequestHttpPost(String url, JsonObject mJsonObject, Callback mCallbackPost);
    }
    public interface Callback
    {
        void onFailure(Exception e);
        void onResponse(JsonObject o1);

    }
}
