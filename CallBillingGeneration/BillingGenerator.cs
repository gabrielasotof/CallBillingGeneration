using System;
using System.Collections.Generic;
using System.Linq;

namespace CallBillingGeneration
{
    internal class BillingGenerator
    {
        private List<Call> calls = new List<Call>();
 
        private double totalCost = 0;

        public BillingGenerator(List<Call> calls) {
            this.calls = calls;
        }

        public double getTotal()
        {
            double cost = 0;

            foreach (Call call in calls)
            {
                cost += call.GetCost();
            }
            return totalCost = cost;
        }

        public void showCalls()
        {
            double cost = 0;

            foreach (Call call in calls)
            {
                Console.WriteLine("Type: " + call.Type);
                Console.WriteLine(", Start : " + call.Start);
                Console.WriteLine(", End : " + call.End);
                Console.WriteLine(", Total Minutes : " + call.GetTotalMinutes());
                Console.WriteLine(", Cost : " + call.GetCost());
                cost += call.GetCost();
            }
            totalCost = cost; 
        }

        public void printBilling() { 
            Console.WriteLine("Client: " + calls.Select(x => x.Client).FirstOrDefault().Person);
            showCalls();
            Console.WriteLine("---- Total Cost: " + totalCost +" ----");
        }
    }
}