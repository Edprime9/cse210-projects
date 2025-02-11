public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Address _address;


    public Order (Product x,Product y,Product z)
    {
        _products.Add(x);
        _products.Add(y);
        _products.Add(z);
    }
    public Order (string m, Address n)
    {
        _customer=new Customer(m,n);
        _address= n;
    }

      //for suming the total of a order
    public double TotalOrder()
    {   
        double sum = 0;
        foreach(Product a in _products)
        {
            sum+=a.TotalCost();  
        }
        return sum;
    }
    
    //for determinig shipping cost
    public double shippingCost()
    {   
        double sum = 0;
            if (_customer.CheckNIG() ==  true)
        {
            return sum+=5;
        }
        else
        {
            return sum+=35;
        }
    }

    public void PackingLabel()
    {   
        foreach(Product a in _products)
        {
            Console.WriteLine(a.Display());
        }

    }

    public void ShippingLabel()
    {
       Console.WriteLine($"{_customer.name()}: Address:- {_address.address()}" );
    }
}