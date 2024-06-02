using System.Collections.Concurrent;

public class Customer
{
    // attributes
    private string _name;
    private Address _address;

    // constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // methods
    public bool IsForeign()
    {
        return _address.IsForeign();        // use method from address here
    }
    public string GetStringRepresentation()
    {
        return $"{_name},{_address.FormatAddress()}";
    }
}