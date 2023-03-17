
namespace TelephoneCharges
{
    public class TelephoneFees
    {
        static void Main()
        {
            Calculation charges = new();
            Console.WriteLine("The number of local calls: ");
            charges.NumberOfLocalCall = Convert.ToInt32(Console.ReadLine());
            charges.CalculateLocalCharge();
            Console.WriteLine("Total charge of local call:");
            Console.WriteLine("RM" + charges.LocalCallTotalCharge);

            Console.WriteLine("The number of outstation calls: ");
            charges.NumberOfOutstationCall = Convert.ToInt32(Console.ReadLine());
            charges.CalculateOutstation();
            Console.WriteLine("Total charge of outstation call:");
            Console.WriteLine("RM" + charges.OutstationCallTotalCharge);

            Console.WriteLine("Grand total telephone charge: ");
            charges.GrandTotalCharge();
            Console.WriteLine("RM" + (charges.GrandTotalTelephoneCharge));
        }
    }
}
