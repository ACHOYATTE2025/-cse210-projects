
public class Job
{

  //variables
  public string _company;
  public string _jobTitle;
  public int _startYear;
  public int _endYear;
  
 
  //constructor
  public Job() { }


  //methods

  public void Display()
  {
     Console.WriteLine($"{_company} ");
  }

  public void displayDetails()
  {
    Console.WriteLine($"{_jobTitle} {_company} {_startYear} {_endYear}");
  }


}