using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Customer
{
    protected string _name;
    protected bool _isInUsa;
    
        
        
    public bool GetIsInUsa()
    {
        return _isInUsa;
    }
    public void SetIsInUsa(bool IsInUSA)
    {
        _isInUsa = IsInUSA;
    }
    public string GetName()
    {
        return _name;
    }
    public void setName(string name)
    {
        _name = name;
    }

    public Customer(string name,bool IsInUSA)
    {
        _name = name;
        
    }
    
    
    public void DisplayCustomerAddress()
    {
        Console.WriteLine($"Name of customer : {_name}");
        //Console.WriteLine($"Is he from USA? {_isInUsa}");
    }
    
    
    
    
}