using System;

namespace Avg_of_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking avg of 3 numbers 
            
            double num1;
            double num2;
            double num3;

            Console.WriteLine("Hi there ! This program will calculate average of 3 numbers .");

            Console.Write("Enter 1st number : ");
            num1 = Convert.ToDouble((Console.ReadLine()));

            Console.Write("Enter 2nd number : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 3rd number : ");
            num3 = Convert.ToDouble(Console.ReadLine());

            double avg = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average of the numbers is : " + avg);

        }
    }
}
