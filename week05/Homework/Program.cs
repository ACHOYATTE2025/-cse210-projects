using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");


        MathAssignment Maths = new("ACHO", "Geometry", "SAMUEL 3", " alinea 6");
        Console.WriteLine(Maths.GetSummary());
        Console.WriteLine(Maths.GetHomeworkList());
        
        WritingAssignment writ = new("Love","Geometry","SAMUEL 3");
        Console.WriteLine(writ.GetSummary());
        Console.WriteLine(writ.GetWritingInformation());
    }
}