using System.Globalization;
using System.Text;

class Order {
    private DateTime _moment;
    private OrderStatus _status;

    private Client _client;
    private List<OrderItem> _items;

    public Order() {
        _client = new Client();
        _items = new List<OrderItem>();
    }

    public Order(DateTime moment, OrderStatus status, Client client) : this() {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public DateTime Moment { get => _moment; set => _moment = value; }
    public OrderStatus Status { get => _status; set => _status = value; }
    public Client Client { get => _client; set => _client = value; }
    public List<OrderItem> Items { get => _items; set => _items = value; }

    public void addItem(OrderItem item) {
        Items.Add(item);
    }
    public void removeItem(OrderItem item) {
        Items.Remove(item);
    }

    public double Total() {
        double sum = 0.0;
        foreach (OrderItem item in Items) {
            sum += item.SubTotal();
        }
        return sum;
    }

    public string Summary() {
        StringBuilder sb = new StringBuilder();
        double totalOrder = 0.0;
        sb.AppendLine("ORDER SUMMARY:");
        sb.AppendLine($"Oder Momento: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
        sb.AppendLine($"Order Status: {Status.ToString()}");
        sb.AppendLine($"Cliente: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
        sb.AppendLine("Order items:");
        foreach (OrderItem item in Items) {
            string prodName = item.Product.Name;
            string unitPrice = "$"+item.Price.ToString("F2", CultureInfo.InvariantCulture);
            string qtdItem = item.Quantity.ToString();
            string totalItemPrice = "$"+item.SubTotal().ToString("F2", CultureInfo.InvariantCulture);            
            sb.AppendLine($"{prodName}, {unitPrice}, Quantity: {qtdItem}, Subtotal: {totalItemPrice}");
            totalOrder += item.SubTotal();
        }
        sb.AppendLine($"Total price: ${totalOrder.ToString("F2", CultureInfo.InvariantCulture)}");
        return sb.ToString();
    }
}