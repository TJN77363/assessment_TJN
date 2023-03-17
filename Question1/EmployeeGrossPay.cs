namespace GrossPay
{
    public class EmployeeGrossPay
    {
        static void Main()
        {
            GrossPayInput grossPayInput = new GrossPayInput();
            Console.WriteLine("Employee Basic Salary: ");
            Console.Write("RM ");
            grossPayInput.BasicPay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Overtime Hours: ");
            grossPayInput.OverTimeHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The employee salary pay: ");
            grossPayInput.CalculateOverTime();
            Console.Write("RM " + grossPayInput.Salary);
        }
    }
}