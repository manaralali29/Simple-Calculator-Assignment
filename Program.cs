using System;

namespace ManarsSimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
              do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Manar's Simple Calculator Program");
                Console.WriteLine("----------------------------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t1 : Addition (+)");
                Console.WriteLine("\t2 : Subtraction (-)");
                Console.WriteLine("\t3 : Multiplication (*)");
                Console.WriteLine("\t4 : Division (/)");
                Console.Write("Enter an option: ");

// user can choose the operation based on the number 
                switch (Console.ReadLine())
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "4":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That is not a valid option. Please try again");
                        break;
                }
                // used a do-while loop to make the calculations continuous when user presses 'y'. If not the program will terminate 
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thank you for using Manar's calculator!");
            Console.ReadKey();
        }
    }
}