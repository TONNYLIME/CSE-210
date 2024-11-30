using  System;

public class Order
{
    private List<Customer> _customer = new List<Customer>();
    private List<Product> _products = new List<Product>();
    public string PackingLable {get; set;}
    public string ShippingLable{get;set;}
    public string ShippingCost{get;set;}
    public bool IsInUSA { get; private set; }
    public virtual List<Product> Details { get; private set; }
    public double Total 
    { 
        get { return Details.Sum( t => t.SubTotal ); }
    }

        public Order()
        {
            this.Details = new List<Product>();
        }
    

    public Order(string shippingLable ,bool IsInUSA,string packingLable)
    {
        ShippingLable = shippingLable;
        PackingLable = packingLable;
        IsInUSA = false;
    }
    
}