public class Activity
{

  //attributes
  private string _name;
  private string _description;
  private int _duration;
  public int _countTime;

  //constructors
  public Activity() { }
  public Activity(string name, string description, int duration)
  {
    this._name = name;
    this._description = description;
    this._duration = duration;

  }

  //Getters 
  public string getName()
  {
    return this._name;
  }
  public string getDescription()
  {
    return this._description;
  }
  public int getDuration()
  {
    return this._duration;
  }
  //Setters
  public void setName(string name)
  {
    this._name = name;
  }

  public void setDescription(string description)
  {
    this._description = description;
  }
   public void setDuration(int duration)
  {
    this._duration = duration;
  }

  //methods
  public void DisplayStartingMessage()
  {

    Console.WriteLine("\n");
    Console.WriteLine($"Welcome to The {this._name}");
    Console.WriteLine("\n");
    Console.WriteLine(getDescription());
    Console.WriteLine("\n");
    Console.Write("How long,in seconds,would you like for your session? ");
    _countTime = int.Parse(Console.ReadLine());
    setDuration(_countTime);
    Console.Clear();
    Console.WriteLine("Get ready...");
   
  }
  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done !!!");
    Console.WriteLine($"You have completed another {getDuration()} seconds of the {getName()}");

  }
  public void ShowSpinner(int seconds)
  {
    char[] spinner = { '|', '/', '-', '\\' };
        int duration = seconds * 1000;
        int interval = 150;

        for (int i = 0; i < duration / interval; i++)
        {
            char spinChar = spinner[i % spinner.Length];
            Console.Write(spinChar);
            Console.Out.Flush();
            Thread.Sleep(interval);
            Console.Write("\b");
        }

            Console.Write(" ");
            Console.Write("\r");
            Console.WriteLine("\n");
  }
  public void ShowCountDown(int second)
  {
    for (int i = second; i >= 0; i--)
    {
      Console.Write("\b");
      Console.Write($"{i}");
      Thread.Sleep(1000);
   }

  }
  
}