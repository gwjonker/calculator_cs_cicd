using System;

namespace Calculator_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare vars
            double num1 = 0; double num2 = 0;

            //Display title
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            //Ask input
            Console.WriteLine("Type first number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type second number");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Ask action
            Console.WriteLine("Choose an option");
            Console.WriteLine("\tA(dd) \tS(ubstract) \tM(ultiply) \tD(ivide)");
            Console.WriteLine("Your option?");

            //Use switch
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Incorrect option");
                    break;
            }

            Console.WriteLine("Press any key to close the Calculator");
            Console.ReadKey();
        }
    }
}
