namespace GrossPay
{
    public class GrossPay
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
            Console.Write("RM " + Salary);
        }

        static void Main()
        {
            GrossPay grossPay = new GrossPay();
            Console.WriteLine("Employee Basic Salary: ");
            Console.Write("RM ");
            grossPay.BasicPay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Overtime Hours: ");
            grossPay.OverTimeHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The employee salary pay: ");
            grossPay.CalculateOverTime();
        }
    }
}