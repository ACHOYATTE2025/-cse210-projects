public class Running : Activity
{

  //attributes
  private double _distance ;

  //constructor
  public Running(int duration):base(duration){}
  public Running(DateTime datetime, int duration, double distance) : base(duration)
  {
    this._distance = distance;
  }

  //getters


  //methods
  public override string GetActivityName()
  {
    return new Running(0).GetType().FullName;
  }
  public override double GetDistance() { return this._distance; }
  public override double GetSpeed() { return GetDistance() / getDuration(); }
  public override double GetPace() { return getDuration() / GetDistance(); }
  
  

}