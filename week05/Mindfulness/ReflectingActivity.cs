public class ReflectingActivity:Activity
{
  //attributes
  private List<string> _prompts;
  private List<string> _questions;


  //constructors
  public ReflectingActivity() {}
  public ReflectingActivity(List<string> prompts, List<string> questions)
  {
    this._prompts = prompts;
    this._questions = questions;
  }

  //getters
  public List<string> getPrompts()
  {
    return this._prompts;
  }

  public List<string> getQuestions()
  {
    return this._questions;
  }
  //Setters

  public void setPrompts(List<string> prompts)
  {
    this._prompts = prompts;
  }
   public void setQuestions(List<string> questions)
  {
    this._questions = questions;
  }

  //methods
  public void Run()
  {
    setName("Reflecting Activity");
    setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    DisplayStartingMessage();
    Console.WriteLine("");
    Console.WriteLine("Consider the folloxing prompt:");
    Console.WriteLine("");
    Console.WriteLine($"---{GetRandomPrompt()}---");
    Console.WriteLine("");
    Console.WriteLine("When you have something in mind , press enter  to continue.");
    Console.ReadLine();
    Console.WriteLine("\n");
    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: "); ShowCountDown(5);
    Console.Clear();
    
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(getDuration());

    DateTime currentTime = DateTime.Now;
    while (currentTime < futureTime)
    {
      DisplayQuestions();ShowSpinner(_countTime);
      DisplayQuestions();ShowSpinner(_countTime);
      DisplayQuestions();ShowSpinner(_countTime);
      currentTime = DateTime.Now;
    }
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

  public string GetRandomQuestion()
  {
    Random random = new Random();
    int index = random.Next(this.getQuestions().Count);
    string randomQuestions = this._questions[index];
    return randomQuestions;
  }

  public void DisplayPrompt()
  {
    Console.WriteLine(GetRandomPrompt());
  }

  public void DisplayQuestions()
  {
    Console.Write(">"+GetRandomQuestion());
  }

}