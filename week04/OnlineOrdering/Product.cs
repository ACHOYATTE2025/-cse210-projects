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

  public void setProductId(int id)
  {
    this._productId = id;
  }

  public void setName(string name)
  {
    this._name = name;
  }

  public void setPrice( double price)
  {
    this._price = price;
  }

  public void setQuantity(int quantity)
  {
    this._quantity = quantity;
  }


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