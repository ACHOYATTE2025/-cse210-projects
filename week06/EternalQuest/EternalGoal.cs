public class EternelGoal : Goal
{

  
  public EternelGoal(string name, string description, string points) : base(name, description, points)
  {
    
  }


  public override void RecordEvent()
  {
     
   }
  public override bool IsCompleted()
  {
    return false;
  }
  public override string GetStringRepresentation() { return ""; }


}