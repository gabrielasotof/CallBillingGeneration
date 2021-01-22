using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    class WeekendTariff : ITariff
    {
        //weekend calls at 0.01 pence per minute
        private double pence = 0.01;

        public string Name { get; set; }
        public int Priority { get; set; }
        public double Pence
        {
            get { return this.pence; }
            set { this.pence = value; }
        }

        public WeekendTariff() { }

        public Boolean Is(DateTime call) 
        {
            if ((call.DayOfWeek == DayOfWeek.Saturday) || (call.DayOfWeek == DayOfWeek.Sunday))
            {
                return true;
            }
            return false;
        }
    }
}
