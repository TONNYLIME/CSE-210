using System;

public class Product : Customer
{
    protected string _productId;
    protected string _productName;
    protected float _productPrice;
    protected int _productQuantity;
    public string GetProductId()
    {
        return _productId;
    }
    public void setProductId(string productId)
    {
        _productId = productId;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public void setProductName(string productName)
    {
        _productName = productName;
    }
    public float GetProductPrice()
    {
        return _productPrice;
    }
    public void setProductPrice(float productPrice)
    {
        _productPrice = productPrice;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public void setProductQuantity(int productQuantity)
    {
        _productQuantity = productQuantity;
    }

    public Product(string name,bool IsInUSA,string productId,string productName,float productPrice,int productQuantity) : base(name,IsInUSA)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public float GetProductCost()
    {
        return _productPrice * _productQuantity;
    }
    public void ProductCost()
    {
        Console.WriteLine($"The price of the product {_name} ordered is :Ksh {GetProductCost()}");
    }
}