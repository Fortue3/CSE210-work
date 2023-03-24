using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private int id;
    private double price;
    private int quantity;

    public Product(string name, int id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name { get { return name; } }
    public int Id { get { return id; } }
    public double Price { get { return price * quantity; } }
    public int Quantity { get { return quantity; } }
}

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string State { get { return state; } }
    public string Country { get { return country; } }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state} {country}";
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name { get { return name; } }
    public Address Address { get { return address; } }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.Price;
        }
        if (customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"{product.Name} (id: {product.Id}) x {product.Quantity}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"{customer.Name}\n{customer.Address.GetFullAddress()}";
        return label;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("No 567 Clover Rd", "New York", "NY", "USA");
        Customer customer1 = new Customer("Jameson Brown", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Product A", 1, 10.0, 2),
            new Product("Product B", 2, 20.0, 1)
        };
        Order order1 = new Order(products1, customer1);

        Address address2 = new Address("55 Mhondiwa Ascot", "Midlands Province", "Gweru", "Zimbabwe");
        Customer customer2 = new Customer("Fortunate Kwenda", address2);
         List<Product> products2 = new List<Product>
        {
            new Product("Product C", 3, 15.0, 3),
            new Product("Product D", 4, 25.0, 2),
            new Product("Product E", 5, 5.0, 4)
        };
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total price: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total price: $" + order2.GetTotalPrice());
    }
}

