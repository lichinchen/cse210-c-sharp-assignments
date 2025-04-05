using System;                   // Import System namespace

// Tasks of this Class:
// Store address information
// Get individual address parts
// Format full address
public class Address            // Define a class called Address
{
    private string _street;    // Private fields
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;

    // Constructor
    public Address(string street, string city, string state, string country, string zipCode)
    {
        // Initialize
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }

    // Getter for Country
    // To check if the customer lives in USA or another country
    // Used in the Order class → ShippingCost() method
    public string GetCountry()
    {
        return _country;
    }

    // Method to get full address
    public string FullAddress()
    {
        string street = _street;
        string cityState = $"{_city}, {_state}";
        string countryZip = $"{_country} {_zipCode}";
    
        string fullAddress = $"{street}\n{cityState}\n{countryZip}";   // Combine all parts into one string with new lines

        return fullAddress;
    }
}
