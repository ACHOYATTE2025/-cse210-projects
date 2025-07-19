using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference1 = new Reference("Malachi", 3, 10);
        Word word1 = new Word("Bring all the tithes into the storehouse, that there may be food in my house. Now therefore prove me in this, says the Lord of hosts, if I will not open for you the windows of heaven and pour out for you a blessing that will not flow.");
        Scripture scripture = new Scripture(reference1,word1.getText( ));

        string answer= "";
        while (answer != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            answer = Console.ReadLine();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            answer = Console.ReadLine();
            
            if (scripture.isCompletelyHidden()){
                Console.WriteLine("\n🎉 All the words are now hidden. Congratulations on memorizing!");
                Console.WriteLine($"Numbers of keyboard pressed : {scripture.getCounDoc()/3}");
                break;
            }
            if (answer != "quit")
            {
                scripture.HideRandomWords(3); // Cache 3 mots à chaque tour
            }
        }
        }
    }
