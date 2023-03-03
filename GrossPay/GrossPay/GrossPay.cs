namespace GrossPay
{
    public class GrossPay
    {
        public const float OverTimeRate = 1.50f;
        public float BasicPay { get; set; }
        public int OverTimeHours { get; set; }

        public int CalculateGrossPay()
        {
            if (OverTimeHours > 50)
            {
                Console.WriteLine("The employee have reached maximum overtime!");
            }
            else
            {
                Console.WriteLine(BasicPay + (OverTimeHours * OverTimeRate));
            }
            return Main();
        }

        static void Main()
        {
            GrossPay Overtime = new GrossPay();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Overtime.OverTimeHours);  // Print the value of model
        }

        //public  int Main()
        //{
        //    GrossPay gP = new GrossPay();
        //    gP.CalculateOverTime();
        //}

    }
}