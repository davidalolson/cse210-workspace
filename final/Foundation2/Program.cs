using System;
class Program
{
    static void Main(string[] args)
    {
        // variables
        List<Order> orders = new List<Order>();

        /*****************************************************

            [ORDER]
            David Wise
            673 London Rd,
            Coalville, North West Leicestershire, United Kingdom

            [PRODUCTS]
            <20008000> | $0.20 | 2222N PNP Transistor {x12}
            <20007FFC> | $0.80 | DM75LS175N IC       {x04}
            <20007FF8> | $0.05 | 1KΩ Potentiometer   {x20}

        *****************************************************/
        // create list to store products
        List<Product> products0 = new List<Product>();
        
        // create address
        Address address0 = new Address("673 London Rd", "Coalville", "North West Leicestershire", "United Kingdom");
        
        // create customer with address
        Customer customer0 = new Customer("David Wise", address0);

        // create products
        Product product0_0 = new Product("2222N PNP Transistor", "20008000", .2, 12);
        Product product0_1 = new Product("DM75LS175N IC", "20007FFC", .8, 4);
        Product product0_2 = new Product("1KΩ Potentiometer", "20007FF8", .05, 20);

        // add products to list
        products0.Add(product0_0);
        products0.Add(product0_1);
        products0.Add(product0_2);

        // create order
        Order order0 = new Order(customer0, products0);

        // save order to list
        orders.Add(order0);

        /*****************************************************

            [ORDER]
            Warren Robinett

            1265 Borregas Ave 
            Sunnyvale, California, United States

            [PRODUCTS]
            <20007FF4> | $0.10 | 10µ Farad Capacitor {x20}
            <20007FF0> | $400. | Oscilloscope        {x01}
            <20007FEC> | $1.99 | Chocolate Bar       {x05}
            
        *****************************************************/
        // create list to store products
        List<Product> products1 = new List<Product>();

        // create address
        Address address1 = new Address("1265 Borregas Ave", "Sunnyvale", "California", "United States");
        
        // create customer with address
        Customer customer1 = new Customer("Warren Robinett", address1);

        // create products
        Product product1_0 = new Product("10µ Farad Capacitor", "20007FF4", .1, 20);
        Product product1_1 = new Product("Oscilloscope", "20007FF0", 400, 1);
        Product product1_2 = new Product("Chocolate Bar", "20007FEC", 1.99, 5);

        // add products to list
        products1.Add(product1_0);
        products1.Add(product1_1);
        products1.Add(product1_2);

        // create order
        Order order1 = new Order(customer1, products1);

        // save order to list
        orders.Add(order1);

        /*****************************************************

            [ORDER]
            Howard Lincoln

            4600 150th Ave NE, 
            Redmond, Washington, United States

            [PRODUCTS]
            <20007FE8> | $0.15 | Infrared Photo-Diode {x05}
            <20007FE4> | $0.05 | 5mm Hardware Button  {x80}
            <20007FE0> | $0.80 | 74LS390PC IC         {x02}
            
        *****************************************************/
        // create list to store products
        List<Product> products2 = new List<Product>();

        // create address
        Address address2 = new Address("4600 150th Ave NE", "Redmond", "Washington", "United States");
        
        // create customer with address
        Customer customer2 = new Customer("Howard Lincoln", address2);

        // create products
        Product product2_0 = new Product("Infrared Photo-Diode", "20007FE8", .15, 5);
        Product product2_1 = new Product("5mm Hardware Button", "20007FE4", .05, 80);
        Product product2_2 = new Product("74LS390PC IC", "20007FE0", .8, 2);

        // add products to list
        products2.Add(product2_0);
        products2.Add(product2_1);
        products2.Add(product2_2);

        // create order
        Order order2 = new Order(customer2, products2);

        // save order to list
        orders.Add(order2);

        // display packing label, shipping label, and total price
        foreach(Order order in orders)
        {
            Console.WriteLine();
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine("$" + order.TotalCost().ToString("F2"));
            Console.WriteLine();
        }
    }
}