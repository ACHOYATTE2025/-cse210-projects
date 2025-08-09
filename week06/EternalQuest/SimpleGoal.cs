public class SimpleGoal : Goal
{
  private bool _isComplete ;


  
  public SimpleGoal(){}
  public SimpleGoal(string name, string description, string points) : base(name, description, points)
  {
    this._isComplete = false;
  }

  public void setIscomplete(bool sim)
  {
    this._isComplete= sim;
 }


  public override void RecordEvent()
  {
    this._isComplete = true;
  }
  public override bool IsCompleted()
  {
    return this._isComplete;
  }
  public override string GetStringRepresentation() { return ""; }

}