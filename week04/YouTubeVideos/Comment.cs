public class Comment{

  //attributes
  private string _name;
  private string _text;
 
 


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


  public string getText() {
    return this._text;
  }
  


}