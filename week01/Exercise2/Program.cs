using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Please enter your grade pourcentage :");
        string gradePoucentage = Console.ReadLine();
        float gradeValue = float.Parse(gradePoucentage);
        String grade = "";

        if (gradeValue > 0)
        {


            if (gradeValue >= 90)
            {
                grade = "A";
                if (gradeValue >= 90 && gradeValue < 93)
                {
                    grade = "A-";
                }
                if (gradeValue >= 90 && gradeValue < 98)
                {
                    grade = "A+";
                }
            }


            else if (gradeValue >= 80 && gradeValue < 90)
            {
                grade = "B";
                if (gradeValue >= 80 && gradeValue < 83)
                {
                    grade = "B-";
                }
                if (gradeValue >= 80 && gradeValue < 88)
                {
                    grade = "B+";
                }
            }

            else if (gradeValue >= 70 && gradeValue < 80)
            {
                grade = "C";
                if (gradeValue >= 70 && gradeValue < 73)
                {
                    grade = "C-";
                }
                if (gradeValue >= 70 && gradeValue < 78)
                {
                    grade = "C+";
                }

            }
            else if (gradeValue >= 60 && gradeValue < 70)
            {
                grade = "D";
                  if (gradeValue >= 60 && gradeValue < 73)
                    {
                        grade = "D-";
                    }
             if (gradeValue >= 60 && gradeValue < 78)
                    {
                        grade = "D+";
                    }
            }

            else
            {
                grade = "F";
            }
            Console.WriteLine($"Your Grade is :{grade}");
        }
    }
}