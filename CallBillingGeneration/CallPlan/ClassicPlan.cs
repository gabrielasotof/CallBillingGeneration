using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallBillingGeneration
{
    public class ClassicPlan : ICallPlan
    {
        private IList<ITariff> tariffs = new List<ITariff>();
        public ClassicPlan()
        {
            tariffs.Add(new WeekendTariff()
            {
                Name = "Weekend",
                Pence = 0.01,
                Priority = 1
            });
            tariffs.Add(new LateNightTariff()
            {
                Name = "Late Night",
                Pence = 0.02,
                Priority = 1
            });
            tariffs.Add(new RegularTariff()
            {
                Name = "Regular",
                Pence = 0.05,
                Priority = 3
            });
        }

        public IList<ITariff> GetTariffs()
        {
            return tariffs.OrderBy(x => x.Priority).ToList<ITariff>();
        }

        public double GetPencebyTariff(DateTime minuteCall)
        {
            var tariffs = GetTariffs();
            foreach (ITariff tariff in GetTariffs())
            {
                if (tariff.Is(minuteCall))
                {
                    return tariff.Pence;
                }
            }
            return tariffs.OrderByDescending(x => x.Priority).FirstOrDefault().Pence;
        }
    }
}
