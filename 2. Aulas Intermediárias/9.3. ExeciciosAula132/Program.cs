using System.Globalization;

string name, email;
DateTime birth;
OrderStatus status;
int qtdOrders;
Order order;

Console.Clear();

Console.WriteLine("Enter client data: ");

Console.Write("Name: ");
name = new String(Console.ReadLine());
Console.Write("Email: ");
email = new String(Console.ReadLine());
Console.Write("Birth date (DD/MM/YYYY): ");
birth = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
status = Enum.Parse<OrderStatus>(new String(Console.ReadLine()));

order = new Order(
    DateTime.Now,
    status,
    new Client(
        name, email, birth
    )    
);

Console.WriteLine("How many items to this order? ");
qtdOrders = int.Parse(Console.ReadLine() ?? "0");
for (int i = 0; i < qtdOrders; i++) {
    Console.WriteLine($"Enter #{i+1} item data: ");
    Console.Write("Product name: ");
    string productName = new String(Console.ReadLine());
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int qtd = int.Parse(Console.ReadLine() ?? "0");
    order.addItem(new OrderItem(qtd, price, new Product(productName, price)));
}

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine(order.Summary());