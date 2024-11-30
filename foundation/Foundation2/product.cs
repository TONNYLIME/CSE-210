using System;

public class Product
{
    private string _productId;
    private string _productName;
    private float _productPrice;
    private int _productQuantity;

    public float GetTotalCost()
    {
        return(_productPrice * _productQuantity);
    }

    internal void Add(object value)
    {
        throw new NotImplementedException();
    }

    public double SubTotal { get { return this._productPrice * this._productQuantity; } }
}