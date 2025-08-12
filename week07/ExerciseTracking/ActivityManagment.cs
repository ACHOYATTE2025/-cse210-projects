public class ActivityManagment{

  //attributes
  private List<Activity> _activities;


  //constructors
  public ActivityManagment()
  {
    this._activities = new List<Activity>();
  }


  //setters
  public  void setActivities(Activity activites){
    this._activities.Add(activites);
  }

  //methods
  public void DisplayAll(){
    foreach (var item in _activities)
    {
      Console.WriteLine(item.GetSummary());
    }
  }
}