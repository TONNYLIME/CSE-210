using System;

public class OrderLibrary
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        private List<Product> scriptures = new List<Product>();
    public void AddProduct(Product product, string text)
    {
        //product.Add(new(product, text));
    }
    }
