using System;

class Program
{
    static void Main(string[] args)
    {
       // addresses
        Address address1 = new Address("23 Regent Rd.", "Freetown", "WA", "Sierra Leone");
        Address address2 = new Address("182-21 150th Avenue", "SpringField", "NY", "USA");

        //customers
        Customer customer1 = new Customer("John Conteh", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // products
        Product product1 = new Product("Laptop", "LPT123", 999.99, 1);
        Product product2 = new Product("Mouse", "MSE456", 25.99, 2);
        Product product3 = new Product("Keyboard", "KBD789", 49.99, 1);
        Product product4 = new Product("Monitor", "MNT012", 199.99, 2);

        // orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // packing and shipping labels and total cost
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}