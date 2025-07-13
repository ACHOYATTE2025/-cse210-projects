using System;
using System.Collections;


 class Program
{
    static void Main(string[] args)
    {   bool _while=true;
       
        Journal journal = new Journal();
       

       

        Console.WriteLine("Hello World! This is the Journal Project.");
        while (_while)
        {
            Console.WriteLine("Please select one of the following choices :\n 1.Write\n 2.Display\n 3.Load\n 4.Save\n 5.Save in database\n 6.Load from Database\n 7.Quit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Entry entry = new Entry();
                    entry.Display();
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Enter filename to load (ex: journal.txt): ");
                    string fileNameload = Console.ReadLine();
                    journal.LoadFromFile(fileNameload);
                    break;
                case 4:
                    Console.WriteLine("Enter filename to save_in Text file (ex: journal.txt): ");
                    string fileNamesave = Console.ReadLine();
                    journal.SaveToFile(fileNamesave);
                    break;
                case 5:
                    Console.WriteLine("Enter filename to save_in DataBase (ex: journal.db): ");
                    string fileNamesavedb = Console.ReadLine();
                    journal.SaveToDatabase(fileNamesavedb);
                    break;
                    
                case 6:
                    Console.WriteLine("Enter filename to load (ex: journal.db): ");
                    string fileNameloaddb = Console.ReadLine();
                    journal.LoadFromDatabase(fileNameloaddb);
                    
                    break;
                case 7:
                    Console.WriteLine("Bye !!!!!!!!!");
                    _while = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice !!!!!!!");
                    break;
            }
        }

    }
}