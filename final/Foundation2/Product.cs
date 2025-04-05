using System;  // Import System namespace

// Tasks of this Class
// Store product information
// get product details
// Calculate total cost of the product

// Define Product class
public class Product
{
    // Private field 
    private string _productName;
    private string _productNo;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string productName, string productNo, double price, int quantity)
    {
        _productName = productName;
        _productNo = productNo;
        _price = price;
        _quantity = quantity;
    }

    // Getter for ProductName
    // Used in Order.cs
    // To show product name in order summary
    public string GetProductName()
    {
        return _productName;
    }

    // Getter for ProductNo
    // Used in Order.cs
    // To show product number in packing label
    public string GetProductNo()
    {
        return _productNo;
    }

    // Getter for Price
    // Used in Order class
    // To get the price of one item
    public double GetPrice()
    {
        return _price;
    }

    // Getter for Quantity
    // Used in Order class
    // To get how many items the customer wants
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
