class Product {
    private string _name;
    private double _price;

    public Product() {
        _name = "";
    }

    public Product(string name, double price) : this() {
        Name = name;
        Price = price;
    }

    public string Name { get => _name; set => _name = value; }
    public double Price { get => _price; set => _price = value; }
}