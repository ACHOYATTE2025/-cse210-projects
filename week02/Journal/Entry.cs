
public class Entry
{
  //attributes
  public string _date;
  public string _promptText;
  public string _entryText;
  PromptGenerator promptGenerator = new PromptGenerator();

  //methods
  public void Display()

  {
    
    
    _promptText = promptGenerator.GetRandomPrompt();
    Console.WriteLine(_promptText);
    _entryText = Console.ReadLine();
    DateTime dateWithoutHour = DateTime.Now.Date;
    _date = dateWithoutHour.ToString("dd/MM/yyyy");

     
    
  }
}