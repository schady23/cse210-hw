using System;
using System.Collections.Generic;

class Program
{
    public static List<Customer> customers = new List<Customer>();
    public static List<Order> orders = new List<Order>();
    static void Main(string[] args)
    {
        Address address1 = new Address("455 Super Street.", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Ryan Schader", address1);

        Address address2 = new Address("123 Bad Street.", "Calgary", "Alberta", "Canada");
        Customer customer2 = new Customer("Jimmy Maple", address2);

        Product product1 = new Product("iPad Air 5th gen", "01", 600.0, 1);
        Product product2 = new Product("AirPods Pro 2nd gen", "02", 230.0, 2);
        Product product3 = new Product("iPhone 13", "03", 700.0, 1);
        Product product4 = new Product("Macbook 14inch M2", "04", 1100.0, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine("");

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}