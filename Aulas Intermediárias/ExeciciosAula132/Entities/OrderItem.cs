using System.Collections.Specialized;

class OrderItem {
    private int _quantity;
    private double _price;
    private Product product;

    public OrderItem() {
        product = new Product();
    }

    public OrderItem(int quantity, double price, Product product) : this() {
        Quantity = quantity;
        Price = price;
        Product = product;
    }

    public int Quantity { get => _quantity; set => _quantity = value; }
    public double Price { get => _price; set => _price = value; }
    internal Product Product { get => product; set => product = value; }

    public double SubTotal() {
        return Quantity * Price;
    }

}