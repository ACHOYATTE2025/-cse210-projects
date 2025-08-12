public class Activity
{

  //attributes
  private DateTime _datetime;
  private int _duration;


  //constructors

  public Activity(int duration)
  {
    this._datetime = DateTime.Now.Date;
    this._duration = duration;
  }


  //getters
  public int getDuration() { return this._duration; }



  //methods
    public virtual string GetActivityName()
  {
    return new Activity(0).GetType().FullName;
  }
  public virtual double GetDistance() { return 0; }
  public virtual double GetSpeed() { return 0; }
  public virtual double GetPace() { return 0; }
  public virtual string GetSummary()
  {
    return $"{this._datetime.ToString("dd/MM/yyyy")} {GetActivityName()}({this._duration} min):Distance {GetDistance()} km ,Speed:{Math.Round(GetSpeed())} Kph,Pace:{Math.Round(GetPace(), 1)} min per Km";
  }

}