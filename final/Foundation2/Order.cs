using System;                       // Import System namespace
using System.Collections.Generic;   // For using list

// Tasks of this Class 
// Add products to the order and track them
// Calculate the total price of the order
// Calculate shipping cost
// Generate packing label
// Generate shipping label

// Define Order class
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total price of the order
    public double GetFinalPrice()
    {
        double totalAmount = 0;                                     // Initialize total amount

        foreach (Product product in _products)                      // Loop through products
        {
            totalAmount += product.ComputeProductTotal();           // Add product total price
        }

        totalAmount += ShippingCost();                              // Add the shipping cost

        return totalAmount;
    }

    // Method to calculate shipping cost
    public double ShippingCost()
    {
        double shippingCost;

        string country = _customer.GetAddress().GetCountry().ToLower();  // Get customer's country

        if (country == "usa")                                            // Check if the country is USA
        {
            shippingCost = 5.00;                                         // Shipping cost for USA
        }
        else
        {
            shippingCost = 35.00;                                        // Shipping cost for international
        }
        
        return shippingCost;                                             // Return shipping cost
    }

    // Method to get packing label 
    // Encapsulated product information
    public string PackingLabel()
    {
        string label = "--- Packing Label: ---\n";                                      // Start packing label string
        foreach (Product product in _products)                                          // Loop through products
        {
            label += product.GetPackingDetails();                                       // using Product's method to add formatted product details
            label += "\n"; 
        }

        double shippingCost = ShippingCost();                                           // Calculate shipping cost
        label += $"* Shipping Cost: ${shippingCost:F2}\n";                              // Add shipping cost to label
    
        return label; 
    }

    // Method to get shipping label
    public string ShippingLabel()
    {
        string label = "Shipping Label:\n";                              // Start shipping label string
        string name = _customer.GetName();                               // Get customer name
        string address = _customer.GetAddress().FullAddress();           // Get customer address
    
        return $"{label}\nTo: {name}\n{address}\n";                      // Return formatted shipping label
    }

    // Method to calculate estimated delivery date
    public string DeliveryDate()
    {
        DateTime DeliveryDate;
        string country = _customer.GetAddress().GetCountry().ToLower();

        if (country == "usa")                         // Check if the customer is in the USA
        {
            DeliveryDate = DateTime.Now.AddDays(3);   // 3-5 business days for USA
        }
        else
        {
            DeliveryDate = DateTime.Now.AddDays(7);   // 7-14 business days for international
        }

        return $"Estimated Delivery Date: {DeliveryDate:dd-MM-yyyy}";
    }
}
