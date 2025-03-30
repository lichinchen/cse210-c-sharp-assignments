public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _postalCode;
    private string _country;

    public Address(string street, string city, string state, string postalCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_postalCode}, {_country}";
    }
}
