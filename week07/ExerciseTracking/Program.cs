using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        //make current date
        DateTime dateTime = DateTime.Now.Date;

        //instanciate ActivityManagement
        ActivityManagment activityManage = new ActivityManagment();

        //instanciate diffrents activities
        Running running = new Running(dateTime, 12, 20);
        Cycling cycling = new Cycling(dateTime, 30, 8);
        Swimming swimming = new Swimming(dateTime, 5, 5);

        activityManage.setActivities(running);
        activityManage.setActivities(cycling);
        activityManage.setActivities(swimming);
       

        activityManage.DisplayAll();
         
       
    }
}