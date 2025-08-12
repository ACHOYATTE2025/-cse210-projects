public class Cycling:Activity{

  //attributes
  private double _distancex;

  //constructor
  public Cycling(int duration):base(duration){}
  public Cycling(DateTime datetime, int duration, double distancex) : base(duration)
  {
    this._distancex = distancex;
  }



  //methods
 public override string GetActivityName()
  {
    return new Cycling(0).GetType().FullName;
  }
  public override double GetDistance() { return this._distancex; }
  public override double GetSpeed(){return GetDistance() / getDuration() * 60;}
  public override double GetPace(){return getDuration()/GetDistance();}

}

