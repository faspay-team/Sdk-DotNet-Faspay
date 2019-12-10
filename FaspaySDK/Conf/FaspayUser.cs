using System;
using System.Text;
using FaspayApi.Utils;

namespace FaspayApi.Conf
{
    public class FaspayUser
    {
        public FaspayUser()
        {
        }
        public FaspayUser(String merchantName, String merchantId, String userId, String password, String redirectUrl)
        {
            this.merchantName = merchantName;
            this.merchantId = merchantId;
            this.userId = userId;
            this.password = password;
            this.redirectUrl = redirectUrl;
        }
        public String merchantName
        {
            get;
            set;
        }
        public String merchantId
        {
            get;
            set;
        }
        public String userId
        {
            get;
            set;
        }
        public String password
        {
            get;
            set;
        }
        public String redirectUrl
        {
            get;
            set;
        }
        public String calculateSignature()
        {
            String userAndPass = new StringBuilder(userId).Append(password).ToString();
            Console.WriteLine("raw "+userAndPass); 
            Console.WriteLine("md5 = "+ DiggestUtils.md5(userAndPass));
            return DiggestUtils.sha1(DiggestUtils.md5(userAndPass));
        }
    }
}
