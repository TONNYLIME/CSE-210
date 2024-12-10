using System;
using System.Dynamic;
public class Address : Customer
{
    protected string _street;
    protected string  _city;
    protected string _stateOrProvince;
    protected string _country;
    
    public string GetStreet()
    {
        return _street;
    }
    public void setStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void setCity(string city)
    {
        _city = city;
    }
    public string GetStateOrProvive()
    {
        return _stateOrProvince;
    }
    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
     public bool GetIsInUsa()
    {
        return _isInUsa;
    }
    
    public Address( string name, bool IsInUSA,string street, string city,string stateOrProvince,string country) :base(name,IsInUSA)
    {
        _city = city;
        _street = street;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public void DisplayCustomerAddress()
    {
        Console.WriteLine($"Is {_name} from USA? {_isInUsa}");
        Console.WriteLine($"Address:Street- {_street},City-{_city},Province-{_stateOrProvince},Country-{_country}");
    }


}