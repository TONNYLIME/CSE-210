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
}