public class Product
{
    // attributes
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _price = price * quantity;
        _productID = productID;
        _quantity = quantity;
    }

    // methods
    public string GetStringRepresentation()
    {
        return $"{_name},{_productID},{_price},{_quantity}";
    }
}