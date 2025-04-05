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
    // When making a label to know the customer's name 
    public string GetName()
    {
        return _name;
    }

    // Getter for Address
    // To get the shipping address in the Order class
    public Address GetAddress()
    {
        return _address;
    }
}
