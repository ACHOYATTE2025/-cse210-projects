using System.Security.Cryptography;

public class Reference
{
  //attribute
  private string _book;
  private int _chapter;
  private int _verse;
  private int _endverse;


  //constructors
  public Reference(string _books, int _chapto, int verses)
  {
    this._book = _books;
    this._chapter = _chapto;
    this._verse = verses;

  }

  public Reference(string _booko, int _chaptero, int _verseo, int _endverseo)
  {
    this._book = _booko;
    this._chapter = _chaptero;
    this._verse = _verseo;
    this._endverse = _endverseo;
  }

  //methods
  public string GetDisplayText()
  {
    if (_endverse != null)
        {
            return $"{_book} {_chapter}:{_verse}-{_endverse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
   }

}