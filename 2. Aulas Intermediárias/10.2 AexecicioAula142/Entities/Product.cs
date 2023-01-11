using System.Globalization;

class Product
{
    private string _name;
    private double _price;

    public Product()
    {
        _name = new String("");
    }

    public Product(string name, double price) : this()
    {
        Name = name;
        Price = price;
    }

    public string Name { get => _name; set => _name = value; }
    public double Price { get => _price; set => _price = value; }

    public virtual String PriceTag() {
        return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}