using System;

class Program
{
    static void Main(string[] args)
    {
         Address address1 = new Address("123 Sea St", "Springfield", "CA", "USA");
        Customer customer1 = new Customer("Casey Van", address1);

        Product product1 = new Product("Product 1", "P001", 25.50m, 2);
        Product product2 = new Product("Product 2", "P002", 15.75m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Address address2 = new Address("456 Park Ave", "Bronx", "NY", "USA");
        Customer customer2 = new Customer("Shanique Brown", address2);

        Product product3 = new Product("Product 3", "P003", 10.00m, 4);
        Product product4 = new Product("Product 4", "P004", 12.25m, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }

    }
