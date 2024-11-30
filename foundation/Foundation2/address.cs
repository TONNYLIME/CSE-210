using System;
public class Address
{
    private string _street;
    private string  _city;
    private string _stateOrProvince;
    private string _country;
    public bool IsInUSA { get; private set; }
    public  Address()
    {
        IsInUSA = true;
        IsInUSA = false;
    }
    public Address(string street, string city,string stateOrProvince,string country)
    {
        Console.WriteLine($"{_street},{_city},{_stateOrProvince},{_country}");
    }


}