using System;
using System.Threading;
using System.Globalization;

namespace TheBigOfThree

    //Problem 5. The Biggest of 3 Numbers
    //Write a program that finds the biggest of three numbers.

{
    class TheBigOfThree
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            double third = double.Parse(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("THe biggest is {0}", first);
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("The biggest is {0}", second);
            }
            else if (third > first && third > second)
            {
             Console.WriteLine("The biggest is {0}", third);
            }
        }
    }
}
