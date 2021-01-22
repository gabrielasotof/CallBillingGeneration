using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    class Call
    {
        public Client Client { get; set; }
        public CallType Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Rate { get; set; }

        public double GetTotalMinutes()
        {
            return (this.End - this.Start).TotalMinutes;
        }

        public double GetCost()
        {
            double cost = 0;
            for (var minutes = this.Start; minutes <= this.End; minutes = minutes.AddMinutes(1))
                  cost += 1 * Client.Plan.GetPencebyTariff(minutes);
            return cost; 
        }

    }
}
