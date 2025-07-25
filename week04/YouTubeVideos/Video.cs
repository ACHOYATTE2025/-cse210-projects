using System.Dynamic;

public class Video{

//attributes
  private string _title;
  private string _author;
  private int _length;
  private List<Comment> _comments ;

  //constructor
  public Video(){}

  public Video(string title, string author, int lens)
  {
    this._title = title;
    this._author = author;
    this._length = lens;
  
  }

  //getter and setters
  public string getTitle()
  {
    return this._title;
  }

  public string getAuthor()
  {
    return this._author;
  }

  public int getLength()
  {
    return this._length;
  }

  public void setComments(List<Comment> comment)
  {
    this._comments = comment;
  }


  public List<Comment> getComments()
  {
    return this._comments;
  }



  //methods

  public void addComment(Comment commento)
  {
    this._comments.Add(commento);
  }

  public int getNumberOfComment()
  {
    return this._comments.Count;
  }


}