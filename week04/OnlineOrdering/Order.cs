using System.Collections.Generic;
using System.Text;

// The Order class represents a customer's order (products + customer)
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor links an order to a customer
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Adds a product to the order
    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    // Calculates total cost of all products + shipping
    public double GetTotalCost()
    {
        double total = 0;

        // Add cost of each product
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.LivesInUSA())
            total += 5;      // USA shipping
        else
            total += 35;     // International shipping

        return total;
    }

    // Creates a simple packing label listing product names and IDs
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("PACKING LABEL:");

        foreach (Product p in _products)
        {
            label.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
        }

        return label.ToString();
    }

    // Creates a shipping label with customer name and address
    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
