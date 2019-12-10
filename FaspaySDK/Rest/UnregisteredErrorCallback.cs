using System;
using FaspaySDK.Entity.Err;

namespace FaspaySDK.Rest
{
    public interface UnregisteredErrorCallback
    {
         void onUserNotRegistered(UnregisteredError mUnregisteredError);
    }
}
