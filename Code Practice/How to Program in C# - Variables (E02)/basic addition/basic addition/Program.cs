using System;

namespace basic_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            Console.Write("Enter number 1 :");
            num1 = Convert.ToDouble(Console.ReadLine());
             
            Console.Write("Enter number 2 :");
            num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine("The sum of both numbers is : " + result);
        }
    }
}
