using System;
using System.Collections.Generic;

namespace CallBillingGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call Billing System!");

            Client newClient = new Client("Rachel Green", ClientType.New);

            CallFactory callFactory = new CallFactory();
            List<Call> calls = new List<Call>();

            calls.Add(callFactory.createCall(newClient, CallType.Local, DateTime.Now, DateTime.Now.AddMinutes(60)));
            calls.Add(callFactory.createCall(newClient, CallType.International, DateTime.Now, DateTime.Now.AddMinutes(25)));
            calls.Add(callFactory.createCall(newClient, CallType.Local, DateTime.Now, DateTime.Now.AddMinutes(5)));

            BillingGenerator billing = new BillingGenerator(calls);
            billing.printBilling();


        }
    }
}
