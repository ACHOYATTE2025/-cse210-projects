public class Customer
{
  //attributes
  private string _name;
  private Address _address;

  //constructors
  public Customer() {}

  public Customer(string name, Address address)
  {
    this._name = name;
    this._address = address;
  }

  //getters & Setters
  public string getName()
  {
    return this._name;
  }

  public Address getAddress()
  {
    return this._address;
  }

  //methods
  public bool CheckUsaLocate()
  {

    if (this._address.getCountry() == "USA".ToLower())
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  
}