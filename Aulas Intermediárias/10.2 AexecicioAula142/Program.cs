
using System.Globalization;

Console.Clear();

List<Product> prodList = new List<Product>();
int qtdProduucts;

System.Console.Write("Enter the number of products: ");
qtdProduucts = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < qtdProduucts; i++)  {
    System.Console.WriteLine($"Product #{i+1} data:");
    System.Console.Write("Common, used or imported (c/u/i): ");
    string prodType = new String(Console.ReadLine());

    System.Console.Write("Name: ");
    string name = new String(Console.ReadLine());

    System.Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

    if (prodType.ToUpper().Equals("I")) {
        System.Console.Write("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        prodList.Add(new ImportedProduct(name, price, customsFee));
    } else if (prodType.ToUpper().Equals("U")) {
        System.Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        prodList.Add(new UsedProduct(name, price, manufactureDate));
    } else {
        prodList.Add(new Product(name, price));
    }
}

System.Console.WriteLine();
System.Console.WriteLine("PRICE TAGS: ");
foreach (Product product in prodList) {
    System.Console.WriteLine(product.PriceTag());
}