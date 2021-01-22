using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    public interface ITariff
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public double Pence { get; set; }
        public Boolean Is(DateTime call);
    }
}
