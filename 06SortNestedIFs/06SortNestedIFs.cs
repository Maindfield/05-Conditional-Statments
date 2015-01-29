using System;
using System.Globalization;
using System.Threading;

namespace SortNestedIFs

            //Problem 7. Sort 3 Numbers with Nested Ifs
            //Write a program that enters 3 real numbers and prints them sorted in descending order.
            //Use nested if statements.
            //Note: Don’t use arrays and the built-in sorting functionality.
{
    class SortNestedIFs
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine());



            if (a > b && a > c && b > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (a > b && a > c && b < c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else if (b > a && a > c && b > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if (b > c && c > a && b > c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            else if (c > a && a > b && c > b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}
