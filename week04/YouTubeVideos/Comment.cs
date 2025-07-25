public class Comment{

  //attributes
  private string _name;
  private string _text;
  private int _rate;
 


  //constructor
  public Comment(){}

  public Comment(string name, string text){
    this._name=name;
    this._text = text;
  }

  //getters & setters
  public string getName(){
    return this._name;
  }

  public int  getRate(){
    return this._rate;
  }

  public void setRate(int value){
     this._rate=value;
  }

  public string getText() {
    return this._text;
  }
  
//methods
 public string getStarsFromRate()
{
    return new string('*', _rate);
}


}