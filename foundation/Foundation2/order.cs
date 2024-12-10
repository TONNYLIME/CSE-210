using  System;

public class Order: Product
{
    private List<Customer> _customers = new List<Customer>();
    private List<Product> _products = new List<Product>();
    private float _shippingCost;
    public List<Customer> GetCustomers()
    {
        return _customers;
    }
    public void setCustomers(List<Customer> customers)
    {
        _customers = customers;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void setProducts(List<Product> products)
    {
        _products = products;
    }
    public float GetShippingCost()
    {
         
        return _shippingCost;
    }
    public void setShippingCost(float shippingCost)
    {
        _shippingCost = shippingCost;
    }
    // Constructor to initialize the order
    public Order(string name,bool IsInUSA,string productName,string productId,float productPrice,int productQuantity, List<Product> products, List<Customer> customer):base(name,IsInUSA,productId,productName,productPrice,productQuantity)
    {
        _products = products;
        _customers = customer;
    }
     // Method to calculate the total cost of the order
    //public float GetTotalCost()
    //{
       //  return
        
   // }

    
}