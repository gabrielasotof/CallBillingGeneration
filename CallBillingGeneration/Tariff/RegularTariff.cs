using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    public class RegularTariff : ITariff
    {
        //regular calls at 0.05 pence per minute
        private double pence = 0.05;

        public string Name { get; set; }
        public int Priority { get; set; }
        public double Pence
        {
            get { return this.pence; }
            set { this.pence = value; }
        }

        public RegularTariff() { }

        public Boolean Is(DateTime call) {
            return true;
        }
    }

}
