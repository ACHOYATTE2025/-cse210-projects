using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Boolean reason = true;
        Random randnumber = new Random();
        int guessNumber = randnumber.Next(1, 21);
        Console.WriteLine(guessNumber);
        while (reason)
        {
            Console.Write("What is the magic number? :");
            string numberuser = Console.ReadLine();
            int guessUser = int.Parse(numberuser);
            if (guessUser > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessUser < guessNumber)
            {
                Console.WriteLine("Lower");

            }
            else
            {
                Console.WriteLine(" You guessed it!");
                reason = false;
            }
        }
    }
}