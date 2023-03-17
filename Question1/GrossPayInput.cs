using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossPay
{
    internal class GrossPayInput
    {
        public const decimal OverTimeRate = 1.50m;
        public const int MaxOverTimeHour = 50;
        public decimal BasicPay { get; set; }
        public int OverTimeHours { get; set; }
        public decimal Salary { get; set; }

        public void CalculateOverTime()
        {
            if (OverTimeHours <= MaxOverTimeHour)
            {
                Salary = BasicPay + (OverTimeHours * OverTimeRate);
            }
            if (OverTimeHours > MaxOverTimeHour)
            {
                Salary = BasicPay + (MaxOverTimeHour * OverTimeRate);
            }
        }
    }
}
