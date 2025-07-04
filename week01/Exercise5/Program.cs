using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static String PromptUserName()
        {
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            String number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }


        static int SquareNumber(int numero)
        {
            double numx = Math.Pow(numero,2);
            int result = (int)numx;
            return result;
        }

        static void DisplayResult(int result)
        {
            Console.WriteLine($"Brother Burton, the square of your number is {result}");
        }

        DisplayWelcome();
        PromptUserName();
        DisplayResult(SquareNumber(PromptUserNumber()));
    }
}