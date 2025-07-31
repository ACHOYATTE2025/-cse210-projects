public class BreathingActivity:Activity
{

  //constructor

  public BreathingActivity(string _name,string _description,int _duration):base(_name,_description,_duration) {}

  //methods
  public void Run()
  {
    DisplayStartingMessage();
    ShowSpinner(_countTime);
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(getDuration());

    DateTime currentTime = DateTime.Now;
    while (currentTime < futureTime)
    {
      Console.Write("Breath in..."); ShowCountDown(4); Console.WriteLine("");
      Console.Write("Now Breath out..."); ShowCountDown(6); Console.WriteLine("");
      Console.WriteLine("\n");
      currentTime = DateTime.Now;
    }
    DisplayEndingMessage();
    ShowSpinner(getDuration());
    Console.Clear();
  }

}