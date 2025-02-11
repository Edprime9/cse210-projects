public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street=street;
        _city=city;
        _state=state;
        _country=country;
    }

    public void SetAddress(string street,string city, string state, string country)
    {
        _street=street;
        _city=city;
        _state=state;
        _country=country;
    }

    public bool InNigeria()
    {
        if(_country == "NIG")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string address()
    {
        return $"{_street} {_city} {_state} {_country}";
    }

}