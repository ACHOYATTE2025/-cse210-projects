public class MathAssignment : Assignment
{
  //attributes
  private string _textBookSection;
  private string _problems;

  //constructors

  public MathAssignment() { }
  public MathAssignment(string studentName,string topic,string textBookSection, string problems)
  :base(studentName,topic)
  {
    this._textBookSection = textBookSection;
    this._problems = problems;
  }

  //getters & setters

  public void setTextBookSection(string text)
  {
    this._textBookSection = text;
  }
  public void setProblems(string text)
  {
    this._problems = text;
  }

  public string getTextBookSection()
  {
    return this._textBookSection;
  }

  public string getProblems()
  {
    return this._problems;
  }

  //methods

  public string GetHomeworkList()
  {
    return ($"Section {this.getTextBookSection()}  Problem {this.getProblems()}");
  }

}