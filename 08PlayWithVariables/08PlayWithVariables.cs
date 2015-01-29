using System;
using System.Threading;
using System.Globalization;

namespace PlayWithVariables

    //Problem 9. Play with Int, Double and String
    //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    //If the variable is int or double, the program increases it by one.
    //If the variable is a string, the program appends * at the end.
    //Print the result at the console. Use switch statement.
{
    class PlayWithVariables
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: \n 1 --> int \n 2 --> double \n 3 --> string");
            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                        {
                            Console.WriteLine("Pls enter int number ");
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("It's int : {0}", number + 1);
                            break;
                        }

                case "2":
                        {
                            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

                            Console.WriteLine("Pls enter floating number ");
                            double floatingNumber = double.Parse(Console.ReadLine());
                            Console.WriteLine("It's double : {0}", floatingNumber + 1);
                            break;
                        }

                case "3":
                        {
                            Console.WriteLine("Pls enter some word ");
                            string letters = (Console.ReadLine());
                            Console.WriteLine("It's string : {0}", letters + "*");
                            break;
                        }
            }
        }
    }
}
