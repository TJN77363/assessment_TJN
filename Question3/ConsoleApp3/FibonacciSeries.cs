
namespace FibonacciSeries
{
    public class FibonacciSeries
    {
        static void MyMethod()
        {
            int firstNumber = 1, SecondNumber = 1, nextNumber, terms = 20;
            Console.Write(firstNumber + " " + SecondNumber + " ");
            for (int i = firstNumber; i < terms; i++)
            {
                nextNumber = firstNumber + SecondNumber;
                Console.Write(nextNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
            }
        }

        public static void Main()
        {
            MyMethod();
        }
    }
}