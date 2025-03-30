using System;  // Import System namespace                  

// Tasks of this Class 
// Store customer information
// get customer details

// Define Customer class
public class Customer  
{
    // Private field
    private string _name;  
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getter for Name
    public string GetName()
    {
        return _name;
    }

    // Getter for Address
    public Address GetAddress()
    {
        return _address;
    }
}
