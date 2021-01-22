using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    class CallFactory
    {
        private Client client;
        public Call createCall(Client client, CallType callType, DateTime startCall, DateTime endCall)
        {
            this.client = client;
       
            if (string.Equals(callType, CallType.Local))
            {

                return new Call
                {
                    Client = client,
                    Type = CallType.Local,
                    Start = startCall,
                    End = endCall,
                    Rate = 1
                };
            }
            if (string.Equals(callType, CallType.International))
            {
                return new Call
                {
                    Client = client,
                    Type = CallType.International,
                    Start = startCall,
                    End = endCall,
                    Rate = 2
                };
            }
           
            return null;
        }
    }
}

