using System;
using System.Xml.Schema;

namespace TelephoneCharge
{
    public class TelephoneCharge
    {
        static void Main()
        {
            double FirstHundredCalls = 20.00;
            double SubsequentCalls = 0.10;
            double LocalCallTotalCharge;
            double SubsequentCharges;
            double OutstationCallTotalCharge;            
            float OutstationCallsCharges = 0.50f;

            Console.WriteLine("The number of local calls: ");
            int LocalCall = Convert.ToInt32(Console.ReadLine());
            if (LocalCall > 100)
            {
                Console.WriteLine("First 100 local call charge: ");
                Console.WriteLine("RM" + FirstHundredCalls);
                SubsequentCharges = (LocalCall - 100) * SubsequentCalls;
                Console.WriteLine("Subsequent calls charge: ");
                Console.WriteLine("RM" + SubsequentCharges);
                Console.WriteLine("Total charge of local call: ");
                LocalCallTotalCharge = SubsequentCharges + FirstHundredCalls;
                Console.WriteLine("RM" + LocalCallTotalCharge);

            }
            else
            {
                Console.WriteLine("Total charge of local call: ");
                LocalCallTotalCharge = FirstHundredCalls;
                Console.WriteLine("RM" + LocalCallTotalCharge);
            }

            Console.WriteLine("The number of outstation calls: ");
            int NoOfOutstationCalls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total charge of outstation call: ");
            OutstationCallTotalCharge = NoOfOutstationCalls * OutstationCallsCharges;
            Console.WriteLine("RM" + OutstationCallTotalCharge);
            Console.WriteLine("Grant total:");
            Console.WriteLine("RM" + (LocalCallTotalCharge + OutstationCallTotalCharge));
        }
    }
}