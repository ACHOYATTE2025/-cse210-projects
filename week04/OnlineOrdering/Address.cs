public class Address
{
  //attibutes
  private string _streetAddress;
  private string _city;
  private string _stateOrProvince;
  private string _country;


  //Constructors
  public Address() { }

  public Address(string streetAddress, string city, string state, string country)
  {
    this._streetAddress = streetAddress;
    this._city = city;
    this._stateOrProvince = state;
    this._country = country;
  }

  // Getters & Setters
  public string getCountry()
  {
    return this._country;
  }

  public void SetStreetAddress(string street)
  {
    this._streetAddress = street;
  }

  public void SetCity(string city)
  {
    this._city = city;
  }

  public void setStateOrProvince(string setStateOrProvince)
  {
    this._stateOrProvince = setStateOrProvince;
  }

  public void SetCountry(string country)
  {
    this._country = country;
  }

  //methods
  public Dictionary<string, string> allAddressData()
  {
    Dictionary<string, string> data = new Dictionary<string, string>();
    data["_streetAddress"] = this._streetAddress;
    data["_city"] = this._city;
    data["_stateOrProvince"] = this._stateOrProvince;
    data["_country"] = this._country;

    return data;
  }


  public bool CheckUsaLocate()
  {
    if (this._country == "USA".ToLower())
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}