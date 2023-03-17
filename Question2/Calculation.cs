using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneCharges
{
    internal class Calculation
    {
        public const decimal LocalCallsCharges = 20.00m;
        public const int MaxLocalCall = 100;
        public const decimal SubsequentCalls = 0.10m;
        public const decimal OutstationCallsCharges = 0.50m;
        public int NumberOfLocalCall { get; set; }
        public int NumberOfOutstationCall { get; set; }
        public decimal LocalCallTotalCharge { get; set; }
        public decimal SubsequentCharges { get; set; }
        public decimal OutstationCallTotalCharge { get; set; }
        public decimal GrandTotalTelephoneCharge { get; set; }

        public void CalculateLocalCharge()
        {
            if (NumberOfLocalCall <= MaxLocalCall)
            {
                LocalCallTotalCharge = LocalCallsCharges;
            }
            if (NumberOfLocalCall > MaxLocalCall)
            {
                SubsequentCharges = (NumberOfLocalCall - MaxLocalCall) * SubsequentCalls;
                LocalCallTotalCharge = SubsequentCharges + LocalCallsCharges;
            }
        }

        public void CalculateOutstation()
        {
            OutstationCallTotalCharge = NumberOfOutstationCall * OutstationCallsCharges;
        }

        public void GrandTotalCharge()
        {
            GrandTotalTelephoneCharge = LocalCallTotalCharge + OutstationCallTotalCharge;
        }
    }
}
