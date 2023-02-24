using System;

namespace GrossPay
{
    class GrossPay
    {
        public const float OverTimeRate = 1.50f;
        static void Main()
        {
            Console.WriteLine("Employee Basic Salary: ");
            int BasicPay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Overtime Hours: ");
            int OverTimeHours = Convert.ToInt32(Console.ReadLine());

            if (OverTimeHours > 50)
            {
                Console.WriteLine("The employee have reached maximum overtime!");
            }
            else
            {
                Console.WriteLine("The employee salary pay: ");
                Console.WriteLine(BasicPay + (OverTimeHours * OverTimeRate));
            }
        }
    }
}