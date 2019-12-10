using System;
using System.Collections;
using System.Collections.Generic;

namespace FaspayApi.Entity
{
    public class FaspayPaymentChannelResponse
    {
        public FaspayPaymentChannelResponse()
        {


        }
        public String response
        {
            get;
            set;
        }
        public String merchant_id
        {
            get;
            set;
        }
        public String merchant
        {
            get;
            set;
        }
        public List<FaspayPaymentChannel> payment_channel
        {
            get;
            set;
        } = new List<FaspayPaymentChannel>();

        public String response_code
        {
            get;
            set;
        }
        public String response_desc
        {
            get;
            set;
        }
    }
}


