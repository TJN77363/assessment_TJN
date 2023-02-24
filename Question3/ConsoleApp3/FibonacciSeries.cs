using System;
namespace FibonacciSeries
{
    public class Program
    {
        public static void Main()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, terms;
            terms = 20;

                for(int i = 2; i < terms; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(firstNumber + nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
        }
    }
}