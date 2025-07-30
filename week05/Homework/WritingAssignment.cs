public class WritingAssignment : Assignment
{
  //attributes
  private string _title;


  //constructors

  public WritingAssignment() { }
  public WritingAssignment(string studentName, string topic, string text) :
  base(studentName, topic)
  {
    this._title = text;
   
  }

  //getters & setters

  public void setTitle(string text)
  {
    this._title = text;
  }
  
  public string getTitle()
  {
    return this._title;
  }


  //methods

  public string GetWritingInformation()
  {
    return ($"{this.getTitle()} by {this.getStudentName()} ");
  }

}