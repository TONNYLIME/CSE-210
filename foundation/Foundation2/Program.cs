using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Tonny",false);
        Address address = new Address("Tonny",false,"Ebenezer","Nairobi", "Nairobi", "Kenya" );
        customer.DisplayCustomerAddress();
        address.DisplayCustomerAddress();

        Product product =new Product("Tonny",false,"2020 P Smart","Huawei",12240,2);
        product.ProductCost();
        

    }
}