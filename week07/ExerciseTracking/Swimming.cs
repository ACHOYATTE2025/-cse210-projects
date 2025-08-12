public class Swimming:Activity{

  //attributes
  private double _lap;

  //constructor
  public Swimming(int duration):base(duration){}
  public Swimming(DateTime datetime, int duration, double lap) : base(duration)
  {
    this._lap = lap;
  }


  //methods
 public override string GetActivityName()
  {
    return new Swimming(0).GetType().FullName;
  }
  public override double GetDistance() { return this._lap * 50 / 1000; }
  public override double GetSpeed(){return GetDistance() / getDuration() * 60;}
  public override double GetPace(){return getDuration()/GetDistance();}

}