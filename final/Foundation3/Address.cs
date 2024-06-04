/*
Handles address information and format.
*/
public class Address
{
    // attributes - address information
    private string _street;
    private string _city;
    private string _state;
    // don't need a country here, lets be real

    // constructor
    public Address(string street, string city, string state)
    // initialize values
    {
        _street = street;
        _city = city;
        _state = state;
    }

    // method
    public string FormatAddress()
    // returns address in proper format
    {
        return $"{_street} {_city} {_state}";
    }

}