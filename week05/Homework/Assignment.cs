public class Assignment
{
  //attributes
  private string _studentName;
  private string _topic;


  //constructors

  public Assignment() { }
  public Assignment(string studentName, string topic)
  {
    this._studentName = studentName;
    this._topic = topic;
  }

  //Getters and setters

  public void setStudentName(string studentName)
  {
    this._studentName = studentName;
  }

  public void seTopic(string topic)
  {
    this._topic = topic;
  }

  public string getStudentName() {
    return this._studentName;
  }

   public string getTopic() {
    return this._topic;
  }



  //methods

  public string GetSummary()
  {
    return ($" {this.getStudentName()} -- {this.getTopic()}");
  }

}
