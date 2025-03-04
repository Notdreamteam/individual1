using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveWork1.Core.Tasks
{
    public class Task2Class
    {
        private double Rate { get; }
        private double Percent { get; }

        public Task2Class(double rate, double percent)
        {
            Rate = rate;
            Percent = percent;
        }

        public string CostOfCall(double wd, double ws)
        {
            double WeekdaysCost = ws * Rate;
            double WeekendCost = WeekdaysCost - (wd * Rate * Percent);

            return $"В будние дни: {WeekdaysCost} руб. В выходные дни: {WeekendCost} руб";
        }
    }
}
