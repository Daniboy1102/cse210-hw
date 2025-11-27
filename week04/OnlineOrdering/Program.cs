using System;

// This program creates a few customers, products, and orders.
// Then it prints packing labels, shipping labels, and total cost.
class Program
{
    static void Main(string[] args)
    {
        // ---------------- ORDER 1 ----------------
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Notebook", "A100", 3.50, 4));
        order1.AddProduct(new Product("Pen Pack", "B200", 2.00, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        // ---------------- ORDER 2 ----------------
        Address addr2 = new Address("88 Queen St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Emily Brown", addr2);

        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Phone Case", "X500", 12.99, 1));
        order2.AddProduct(new Product("USB Cable", "U300", 5.50, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
