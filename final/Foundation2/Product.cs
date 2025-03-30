using System;  // Import System namespace

// Tasks of this Class
// Store product information
// get product details
// Calculate total cost of the product

// Define Product class
public class Product
{
    // Private field 
    private string _name;
    private string _productNo;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productNo, double price, int quantity)
    {
        _name = name;
        _productNo = productNo;
        _price = price;
        _quantity = quantity;
    }

    // Getter for Name
    public string GetName()
    {
        return _name;
    }

    // Getter for ProductNo
    public string GetProductNo()
    {
        return _productNo;
    }

    // Getter for Price
    public double GetPrice()
    {
        return _price;
    }

    // Getter for Quantity
    public int GetQuantity()
    {
        return _quantity;
    }

    // Method to calculate the total cost of the product
    public double ComputeProductTotal()
    {
        double itemTotal = _price * _quantity;
        return itemTotal;
    }
}
