using System;
using System.IO;
using System.Xml.Serialization;

namespace FaspaySDK.Entity.Notify
{
    public class NotifyHandler
    {
        public NotifyHandler()
        {
        }
        public String handle(String rawXml)

        {

            XmlSerializer x = new XmlSerializer(typeof(FaspayNotifyResponse));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            StringReader sr = new StringReader(rawXml);
            FaspayNotifyResponse response = (FaspaySDK.Entity.Notify.FaspayNotifyResponse)x.Deserialize(sr);
            FaspayTraceSuccessXMLResponse back = new FaspayTraceSuccessXMLResponse(response);
            x = new XmlSerializer(typeof(FaspayTraceSuccessXMLResponse));
            StringWriter s = new StringWriter();
            x.Serialize(s, back, ns);
            return s.ToString();



        }
    }
}
