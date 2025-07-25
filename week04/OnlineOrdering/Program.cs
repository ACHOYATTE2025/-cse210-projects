using System;

class Program
{
    static void Main(string[] args)
    
    {   
        Console.WriteLine("\n");
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Product product1 = new Product(1, "iphone", 1800, 1);
        Product product2 = new Product(2, "MacBook Pro", 7800, 1);
        Product product3 = new Product(3, "TESLA", 150000, 1);
        Product product4 = new Product(4, "Tacos", 17.10, 5);
        Product product5 = new Product(5, "SODA", 1.5, 7);

        List<Product> products = new List<Product>();

        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);
        products.Add(product5);

        Address address = new Address();
        address.SetStreetAddress("Po box harleyn street");
        address.SetCity("New York");
        address.SetCountry("USA");
        address.setStateOrProvince("Washington");

        Customer customer = new Customer("Abel", address);
        Order order = new Order(products, customer);

        order.totalCostOrder();
        order.labelPacking();
        order.shippinglabel();
        
        
    }
}