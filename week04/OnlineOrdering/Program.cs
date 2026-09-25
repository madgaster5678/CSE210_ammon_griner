using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("145 W 16th Avenue", "Denver", "Colorado", "USA");
        Customer customer1 = new Customer("Dante Sparda", address1);
        Product product1 = new Product(".45 Rounds", 630, 1.30m, 600);
        Product product2 = new Product("Frozen Pizza", 945, 4.00m, 8);
        Product product3 = new Product("Strawberries", 387, 2.58m, 9);
        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);

        Order order1 = new Order(products1, customer1);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($" Total Cost: ${order1.CalculateTotalCost()}");

        Address address2 = new Address("3 chome 3 Yanagi Dori St", "Chuo City", "Tokyo", "Japan");
        Customer customer2 = new Customer("Ren Sato", address2);
        Product product4 = new Product("Strawberries", 387, 2.58m, 10);
        Product product5 = new Product("Milk", 546, 2.00m, 8);
        Product product6 = new Product("Dog Food", 821, 12.00m, 5);
        List<Product> products2 = new List<Product>()
        {
          product4,
          product5,
          product6  
        };
        Order order2 = new Order(products2, customer2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}