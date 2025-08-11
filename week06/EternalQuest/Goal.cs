using System.Reflection.Metadata.Ecma335;

public class Goal
{
  private string _shortName;
  private string _description;
  private string _points;
 



  public Goal(){}
  public Goal(string name, string description, string points)
  {
    this._shortName = name;
    this._description = description;
    this._points = points;
  }


  public void setShortName(String name)
  {
    this._shortName = name;
  }
  

public string getShortName()
  {
    return this._shortName;
  }

  public void setDescription(String description)
  {
    this._description = description;
  }

  public string getDescription()
  {
    return this._description;
  }

  public void setPoint(String point)
  {
    this._points = point;
  }

  public string getpoint()
  {
    return this._points;
  }

  public virtual void RecordEvent() {}
  public virtual bool IsCompleted(){ return false; }
  public virtual string GetDetailsString(){ return ""; } 
  public virtual string GetStringRepresentation(){return "";}
  
}