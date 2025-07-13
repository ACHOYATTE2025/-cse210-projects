using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //variables
        List<int> listNumber = new List<int>();
        int guessNumber = 0;
        int stopwhileLoop = 1;
        int sum = 0;
        double average = 0.0;
        int max = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (stopwhileLoop > 0)
        {
            Console.Write("Enter Number : ");
            String num = Console.ReadLine();
            guessNumber = int.Parse(num);
            if (guessNumber == 0)
            {
                stopwhileLoop = 0;
            }

            listNumber.Add(guessNumber);

        }
        if (listNumber.Count == 0)
        {
            Console.WriteLine("La liste est vide.");
        }
        else
        {
            max = listNumber[0];
            //compute sum and find minimum
            foreach (int i in listNumber)
            {
                sum += i;
                if (i > max)
                {
                    max = i;
                }
            }

            //compute average

            average = sum / listNumber.Count;

        }

        listNumber.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is:{max}");
        foreach (int x in listNumber) {
            Console.WriteLine(x);
        }
    }
  
        

}