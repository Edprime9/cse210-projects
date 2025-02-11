using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the OnlineOrdering Project.");
        Address address = new Address("19 Pipeline Road", "Port Harcourt", "Rivers State", "Nigeria");
        Product firstProduct = new Product("Toyota", "SPORT01", 900, 4);
        Product SecondProduct = new Product("Lexus", "RX350", 400, 5);
        Product ThirdProduct = new Product("Mercedes Benz", "CLE", 100, 1);
        

        //Console.WriteLine(address.InUsa());

        Order order = new Order(firstProduct,SecondProduct,ThirdProduct);
        Order cus = new Order("Del Boateng",address);
      
        order.PackingLabel();
        Console.WriteLine($"Total: ${cus.shippingCost()+order.TotalOrder()}");
        cus.ShippingLabel();
    }
    // Hope this suffices
}