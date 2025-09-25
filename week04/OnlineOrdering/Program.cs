using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        // Create first order with 2 products
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W123", 10.99, 2));
        order1.AddProduct(new Product("Gadget", "G456", 25.50, 1));
        orders.Add(order1);

        // Create second order with 3 products
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Garcia", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T789", 15.00, 3));
        order2.AddProduct(new Product("Doodad", "D012", 8.75, 2));
        order2.AddProduct(new Product("Whatchamacallit", "W345", 12.25, 1));
        orders.Add(order2);

        // Display results for each order
        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
            Console.WriteLine();
        }
    }
}