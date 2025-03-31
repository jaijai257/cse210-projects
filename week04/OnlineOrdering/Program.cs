using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main st", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm st", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Projector", "1001", 1500.24, 1));
        order1.AddProduct(new Product("SPeaker", "1002", 5.99, 4));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "201" , 489.99, 5));
        order2.AddProduct(new Product("Headset", "202" , 49.99, 3));

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}