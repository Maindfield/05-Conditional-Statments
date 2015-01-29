using System;
using System.Threading;
using System.Globalization;

namespace MultiplicationSign

    //Problem 4. Multiplication Sign
    //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    //Use a sequence of if operators.

{
    class MultiplicationSign
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            int c = int.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)

            {
                Console.WriteLine("0");
            }

            else if (a > 0 && b > 0 && c < 0)

              {
                Console.WriteLine("-");
              }

            else if (a < 0 && b > 0 && c > 0)

              {
                Console.WriteLine("-");
              }

            else if (a > 0 && b < 0 && c > 0)

              {
                Console.WriteLine("-");
              }

            else if (a < 0 && b < 0 && c < 0)

              {
                Console.WriteLine("-");
              }

            else
              {
                Console.WriteLine("+");
              }
            
        }
    }
}
