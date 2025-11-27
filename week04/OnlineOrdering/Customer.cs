// The Customer class stores a name and an address.
public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to set name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Checks whether the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    // Returns customer name
    public string GetName()
    {
        return _name;
    }

    // Returns address object
    public Address GetAddress()
    {
        return _address;
    }
}
