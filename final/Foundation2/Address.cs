public class Address
{
    // attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;   

    // constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // methods
    public bool IsForeign()
    {
        return _country != "United States";                     // return the result of this test case
    }
    public string FormatAddress()                               // return a string in packing label format
    {
        return $"{_street}\n{_city}, {_state}, {_country}";
    }

}