
public class Fraction
{
  //attributes
  private int _top;
  private int _bottom;


  //constructors

  public Fraction()
  {
    _top = 0;
    _bottom = 0;
  }
  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom=1;
  }
  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }


  //getters & Setters

  public int GetTop()
  {
    return _top;
  }

  public void SetTop(int top)
  {
    _top = top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public void SetBottom(int bottom)
  {
    _bottom = bottom;
  }


  //methods
  public string GetFractionString()
  {
   
    return GetTop()+ "/"+GetBottom();

  }

  public double GetDecimalValue()
  {
    double result = (double) GetTop() / GetBottom();
    return result;
  }


}