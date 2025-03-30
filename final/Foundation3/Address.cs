// Tasks of this Class
// Store address details
// Sets address details using a constructor
// formatted a full address

// Defines an Address class
public class Address
{
    // Stores the street, city, state, postal code, country name
    private string _street;  
    private string _city;
    private string _state;
    private string _postalCode;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string postalCode, string country)
    {
        // Assigns street, city, state, postalCode, country value
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }

    // Returns the full address 
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_postalCode}, {_country}";
    }
}
