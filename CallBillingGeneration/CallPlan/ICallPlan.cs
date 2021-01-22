using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    public interface ICallPlan
    {
        public IList<ITariff> GetTariffs();

        public double GetPencebyTariff(DateTime minuteCall);
    }
}
