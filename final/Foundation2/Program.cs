using System;  // Import System namespace

// Tasks of this Class
// Create customer orders
// Add products to orders
// Generate order details
// Calculate total order price
// Show how orders and products are created and displayed

// Define Program class
class Program
{
    // Main method
    static void Main(string[] args)
    {
        // Create an Address
        Address address1 = new Address("333 Indigo St", "Lafayette", "IN", "USA", "47909");
        Address address2 = new Address("3624 176th Pl SW", "Lynnwood", "WA", "USA", "98037");
        Address address3 = new Address("456 Elm St", "Vancouver", "BC", "Canada", "V6B 1A1");
        Address address4 = new Address("221B Baker Street", "London", "England", "UK", "NW1 6XE");

        // Create Customers
        Customer customer1 = new Customer("Scott Huang", address1);
        Customer customer2 = new Customer("Chuan Kuo", address2);
        Customer customer3 = new Customer("WenYu Tsai", address3);
        Customer customer4 = new Customer("Silvia Chen", address4);


        // Create Products
        Product product1 = new Product("Laptop", "P001", 1399.99, 1);
        Product product2 = new Product("Cellphone", "P002", 799.99, 2);
        Product product3 = new Product("Telephone", "P003", 499.99, 3);
        Product product4 = new Product("Television", "P004", 999.99, 1);


        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product4);


        Order order4 = new Order(customer4);
        order4.AddProduct(product3);



        // Print details
        Console.WriteLine("\nOrder 1:\n");                                  // Print label for order 1
        Console.WriteLine(order1.PackingLabel());                           // Print packing label for order 1
        Console.WriteLine(order1.ShippingLabel());                          // Print shipping label for order 1
        Console.WriteLine(order1.DeliveryDate());                           // Print estimated delivery date for order 1
        Console.WriteLine($"Total Amount: ${order1.GetFinalPrice():F2}");    // Print total price for order 1
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("\nOrder 2:");                                    
        Console.WriteLine(order2.PackingLabel());                           
        Console.WriteLine(order2.ShippingLabel()); 
        Console.WriteLine(order2.DeliveryDate());                                                  
        Console.WriteLine($"Total Amount: ${order2.GetFinalPrice():F2}");    
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("\nOrder 3:");                                    
        Console.WriteLine(order3.PackingLabel());                           
        Console.WriteLine(order3.ShippingLabel());    
        Console.WriteLine(order3.DeliveryDate());                                                 
        Console.WriteLine($"Total Amount: ${order3.GetFinalPrice():F2}");    
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("\nOrder 4:");                                    
        Console.WriteLine(order4.PackingLabel());                           
        Console.WriteLine(order4.ShippingLabel());   
        Console.WriteLine(order4.DeliveryDate());                                               
        Console.WriteLine($"Total Amount: ${order4.GetFinalPrice():F2}");    
        Console.WriteLine("\n------------------------------------");
    }
}

