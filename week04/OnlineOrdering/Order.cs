using System.Runtime.CompilerServices;

public class Order
{
  //attributes
  private List<Product> _products;
  private Customer _customer;

  private double _costProducts = 0;

  private double _totalCost = 0;
  private int _shipment = 0;


  //Constructors
  public Order() {}

  public Order(List<Product> products, Customer customer)
  {
    this._products = products;
    this._customer = customer;

  }


  //getters & Setters
  public double getTotalCost()
  {
    return this._totalCost;
  }

  //methods
  public void totalCostOrder()
  {

    foreach (var item in _products)
    {
      double pric = item.getPrice();
      double qte = item.getQuantity();
      this._costProducts += (pric * qte);
    }
    if (this._customer.CheckUsaLocate() == true)
    {
      this._shipment = 5;
    }
    else
    {
      this._shipment = 35;
    }
    this._totalCost = this._costProducts + this._shipment;
    Console.WriteLine($"Total Price : {this.getTotalCost()} $ ");
    Console.WriteLine("\n");
  }

  public void labelPacking()
  {

    foreach (var item in this._products)
    {
      Console.WriteLine($"ProductId : {item.getProductId()} --- Name : {item.getName()}");
    }
    Console.WriteLine("\n");
  }

  public void shippinglabel()
  {
  
    Console.WriteLine($"Customer Name : {_customer.getName()}");
    
    foreach (var item in _customer.getAddress().allAddressData())
    {
      Console.WriteLine($"{item.Key}: {item.Value}");
    }
  }
  
}