using System;
using System.Threading;
using System.Globalization;

namespace ExchangeIfGrater

    //Problem 1. Exchange If Greater
    //Write an if-statement that takes two double variables a and b and exchanges their values if the first one 
    //is greater than the second one. As a result print the values a and b, separated by a space.

{
    class ExchangeIfGrater
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b) 
            {
                Console.WriteLine("{0} {1},  {1} {0}", b , a);
            }
            else 
            {
                Console.WriteLine("a is bigger then b");
            }
        }
    }
}
