


public class Word
{
  //attribute
  private string _text;
  private bool _isHidden;

  //constructors
  public Word(string text)
  {
    this._text = text;
    this._isHidden = false;
  }

  //getters setters

  public string getText()
  {
    return this._text;
  }

  public void setText(string text)
  {
    this._text = text;
  }

  //methods
  public void Hide()
  {
    _isHidden = true;
  }
  public void show()
  {
    _isHidden = false;
  }
 
  public string GetDisplayText()
  { 
    return _isHidden ? "_____" : _text;
   }

  internal bool IsHidden()
  {
    return _isHidden;
  }
}