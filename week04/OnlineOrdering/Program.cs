using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 10.0, 2));
        order1.AddProduct(new Product("Pen", "P002", 1.5, 5));

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N003", 5.0, 3));
        order2.AddProduct(new Product("Pencil", "P004", 0.5, 10));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}
