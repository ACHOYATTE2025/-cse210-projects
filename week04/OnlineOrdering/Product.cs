public class Product
{
  //attributes
  private int _productId;
  private string _name;
  private double _price;
  private int _quantity;

  // constructors

  public Product() { }

  public Product(int productId, string name, double price, int quantity)
  {
    this._productId = productId;
    this._name = name;
    this._price = price;
    this._quantity = quantity;
  }


  //getters & setters
  public double getProductId()
  {
    return this._productId;
  }

  public double getPrice()
  {
    return this._price;
  }

  public int getQuantity()
  {
    return this._quantity;
  }

  
  public string getName()
  {
    return this._name;
  }


  //methods
  public double totalCost()
  {
    return this._price * this._quantity;
  }
  

}