using System;
using System.Collections.Generic;


class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World! This is the Resumes Project.");
    Job job1 = new Job();
    Job job2 = new Job();
    job1._company = "MicroSoft";
    job2._company = "Apple";
    job1._jobTitle = "Software Developer";
    job1._startYear = 2025;
    job1._endYear = 2050;
    //job2.Display();
    //job1.displayDetails();

    Resume myResume = new Resume();
    myResume._name = "ACHO";
    myResume._jobs.Add(job1);
    myResume.Display();
    
    

    }
}

