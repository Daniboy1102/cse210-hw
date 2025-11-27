// The Product class represents a single product being purchased.
public class Product
{
    // Private member variables (encapsulation)
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to set up the product
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculates total cost of this product (price * quantity)
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Returns product name
    public string GetName()
    {
        return _name;
    }

    // Returns product ID
    public string GetProductId()
    {
        return _productId;
    }
}
