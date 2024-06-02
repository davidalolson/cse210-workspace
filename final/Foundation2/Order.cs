public class Order {
    // attributes
    private Customer _customer;
    private List<Product> _products;

    // constant attributes
    private const int FOREIGN_MULTIPLIER = 6;
    private const int SHIPPING_COST = 5;
    private const int QUANTITY_IDX = 3;
    private const int PRICE_IDX = 2;
    private const int IDENTIFIER_IDX = 1;                       // for customer address and product ID number
    private const int NAME_IDX = 0;                             // both product and customer have name at the same index


    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
    }
    // methods
    public double TotalCost()                                   // calculate total cost
    {
        // variables
        double total = 0;

        foreach(Product product in _products)
        {
            total += double.Parse(product.GetStringRepresentation().Split(",").ElementAt(PRICE_IDX));       // use string parser to get price, then add to total variable
        }
                                                                // convert bool to integer 1 or 0 to add or remove FOREIGN_MULTIPLIER
        return total + SHIPPING_COST + (SHIPPING_COST * (FOREIGN_MULTIPLIER * int.Parse(_customer.IsForeign().ToString().Replace("True", "1").Replace("False", "0"))));
    }
    public string GetPackingLabel()                             // get details for each product
    {
        // variables
        List<string> strings = new List<string>();              // temporary list to hold string while building

        string name;
        string productID;

        string packingLabel = "";

        foreach(Product product in _products)
        {
            name = product.GetStringRepresentation().Split(",").ElementAt(NAME_IDX);
            productID = product.GetStringRepresentation().Split(",").ElementAt(IDENTIFIER_IDX);

            // build string, use loop to duplicate by quantities
            for(int i = int.Parse(product.GetStringRepresentation().Split(",").ElementAt(QUANTITY_IDX)); i > 0; i--)
            {
                strings.Add(productID + ": ");
                strings.Add(name);
                strings.Add("\n");
            }

            // build complete string
            foreach(string str in strings)
            {
                packingLabel += str;
            }

            // clean memory
            strings.Clear();
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
                                                                // get name, then delete name from formatted address string to avoid splitting at the delimiters
        return $"{_customer.GetStringRepresentation().Split(",").ElementAt(NAME_IDX)}\n{_customer.GetStringRepresentation().Replace(_customer.GetStringRepresentation().Split(",").ElementAt(NAME_IDX) + ",","")}";
    }
}