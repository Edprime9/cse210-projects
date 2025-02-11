using System.Text;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name =name;
        _address=address;
    }
    
    
    public bool CheckNIG()
    {   
        return _address.InNigeria();
    }

    public string name()
    {
        return _name;
    }
}