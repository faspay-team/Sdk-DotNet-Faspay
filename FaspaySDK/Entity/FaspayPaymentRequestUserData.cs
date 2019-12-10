using System;
namespace FaspayApi.Entity
{
    public class FaspayPaymentRequestUserData
    {
        public string bank_userid { get; set; }
        public string msisdn { get; set; }
        public string email { get; set; }
        public string terminal { get; set; }
        public string custNo { get; set; }
        public string custName { get; set; }
        public FaspayPaymentRequestUserData(String msisdn, String email, String terminal, String custNo, String custName)


        {
            this.msisdn = msisdn;
            this.email = email;
            this.terminal = terminal;
            this.custNo = custNo;
            this.custName = custName;
        }
    }
}
