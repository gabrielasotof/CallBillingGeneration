using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    class LateNightTariff : ITariff
    {
        //late night calls(for example from 10pm to 4am) at 0.02 pence per minute
        private double pence = 0.02;
        private int fromHour = 22;
        private int toHour = 4;

        public string Name { get; set; }
        public int Priority { get; set; }

        public double Pence
        {
            get { return this.pence; }
            set { this.pence = value; }
        }

        public LateNightTariff(){}

        public Boolean Is(DateTime call) {
            if (call.Hour >= fromHour && call.Hour <= toHour) {
                return true;
            }
            return false;
        }
    }
}
