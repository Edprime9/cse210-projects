using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create Addresses
        Address nigeriaAddress = new Address("12 Old G.R.A", "Rivers", "PH", "Nigeria");
        Address ghanaAddress = new Address("57-59 Ridge Avenue", "Accra", "AC", "Ghana");

        // Create Customers
        Customer customer1 = new Customer("Morrison Eli", nigeriaAddress);
        Customer customer2 = new Customer("Del Boateng", ghanaAddress);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Toyota", "SPORT01", 900.01m, 4));
        order1.AddProduct(new Product("Lexus", "RX350", 40.99m, 5));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mercedes Benz", "CLE", 100.00m, 1));
        order2.AddProduct(new Product("Porche", "PORCHE001", 30.45m, 1));

        // Display Order Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");
    }
}