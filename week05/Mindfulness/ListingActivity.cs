public class ListingActivity:Activity
{
  //attributes
  private int _count;
  private List<string> _prompts;

  //constructors
  public ListingActivity() { }
  public ListingActivity(string _name, string _description,int _duration, int count, List<string> prompts) : base(_name, _description,_duration)
  {
    this._count = count;
    this._prompts = prompts;
  }

  //getters
  public int getCount()
  {
    return this._count;
  }

  public List<string> getPrompts()
  {
    return this._prompts;
  }


  //methods

  public void Run()
  {
    List<string> answers=new List<string>();
    string anso = "";

    DisplayStartingMessage();
    ShowSpinner(_countTime);
    Console.WriteLine("");
    Console.WriteLine("List as many responses you can to the folloxing prompt:");
    Console.WriteLine($"---{GetRandomPrompt()}---");
    Console.Write("You may begin in: "); ShowCountDown(5);
    Console.WriteLine();
    Console.WriteLine(GetRandomPrompt());

    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(getDuration());

    DateTime currentTime = DateTime.Now;
  
    while (currentTime < futureTime)
    {
      Console.Write(">");anso=Console.ReadLine();
      answers.Add(anso);
      currentTime = DateTime.Now;
    }
    Console.WriteLine($"You listed {answers.Count() } items!");
    DisplayEndingMessage();
    ShowSpinner(getDuration());
    Console.Clear();
    
    
  }


  public string GetRandomPrompt()
  {
   Random random = new Random();
    int index = random.Next(this.getPrompts().Count);
    string randomPrompt = this._prompts[index];
    return randomPrompt;
  }

  public List<string> GetListFromUser()
  {
    return null;
  }

}