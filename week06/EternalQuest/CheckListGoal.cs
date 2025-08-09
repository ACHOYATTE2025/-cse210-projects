public class CheckListGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;


  public CheckListGoal(string name, string description, string points, int target, int bonus)
  : base(name, description, points)
  {
    this._target = target;
    this._bonus = bonus;
  }

  public int getBonus()
  {
    return this._bonus;
  }

  public int getTarget()
  {
    return this._target;
  }
  

  public override void RecordEvent()
  {
    this._amountCompleted = 1;
  }
  public override bool IsCompleted()
  {
    if (this._amountCompleted != 0) return true;
    return false;
  }
  public override  string GetDetailsString() {
    return ""; }
  public override string GetStringRepresentation() {
    return ""; }
  
}