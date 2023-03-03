
namespace TelephoneCharge
{
    public class TelephoneCharge
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
            Console.WriteLine("RM" + LocalCallTotalCharge);
        }

        public void CalculateOutstation()
        {
            OutstationCallTotalCharge = NumberOfOutstationCall * OutstationCallsCharges;
            Console.WriteLine("RM" + OutstationCallTotalCharge);
        }

        public void GrandTotalCharge()
        {
            GrandTotalTelephoneCharge = LocalCallTotalCharge + OutstationCallTotalCharge;
            Console.WriteLine("RM" + (GrandTotalTelephoneCharge));
        }

        static void Main()
        {
            TelephoneCharge telephoneCharge = new();
            Console.WriteLine("The number of local calls: ");
            telephoneCharge.NumberOfLocalCall = Convert.ToInt32(Console.ReadLine());
            telephoneCharge.CalculateLocalCharge();

            Console.WriteLine("The number of outstation calls: ");
            telephoneCharge.NumberOfOutstationCall = Convert.ToInt32(Console.ReadLine());
            telephoneCharge.CalculateOutstation();

            Console.WriteLine("Grand total telephone charge: ");
            telephoneCharge.GrandTotalCharge();
        }
    }
}
