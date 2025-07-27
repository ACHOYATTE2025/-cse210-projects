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

        Customer customer1 = new Customer("AURIEL", address);
        Customer customer2 = new Customer("ABEL", address);
        Order order1 = new Order(products, customer1);
        Order order2 = new Order(products, customer2);


        order1.totalCostOrder();
        order1.labelPacking();
        order1.shippinglabel();
        Console.WriteLine("====================================================");
        order2.totalCostOrder();
        order2.labelPacking();
        order2.shippinglabel();
        
        
    }
}