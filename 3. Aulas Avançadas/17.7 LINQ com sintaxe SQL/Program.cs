using System.Globalization;
using System.Net;
using System.Security.Cryptography;

Console.Clear();

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };


//IEnumerable<Product> r1 = products.Where(p => p.Price < 900 && p.Category.Tier == 1);
var r1 =
    from p in products
    where p.Category.Tier == 1
        && p.Price < 900
    select p;
MyFunc.Print("TIER 1 AND PRICE < 900:", r1);


var r2 =
    from p in products
    where p.Category.Name.Equals("Tools")
    select p.Name;
MyFunc.Print("NAMES OD PRODUCTS FROM TOOLS:", r2);


var r3 =
    from p in products
    where p.Name[0] == 'C'
    select new { p.Name, p.Price, CategoryName = p.Category.Name };
MyFunc.Print("NAMES AND PRICES OF PRODUCTS WITH NAME STATING WITH C", r3);

var r4 = //products.Where(p => p.Category.Tier == 1).OrderByDescending(p => p.Price).ThenBy(p => p.Name);
    from p in products
    where p.Category.Tier == 1
    orderby p.Price descending, p.Name
    select p;
MyFunc.Print("TIER 1 ORDER BY PRICE DESC THEN BY NAME ASC:", r4);

var r5 = //r4.Skip(2).Take(4);
    (from p in r4
     select p).Skip(2).Take(4);
MyFunc.Print("TIER 1 ORDER BY PRICE DESC THEN BY NAME ASC SKIP 2 TAKE 4:", r5);

var r6 = //products.First();
    (from p in products select p).First();
System.Console.WriteLine("First test1: " + r6);
System.Console.WriteLine();

var r7 = //products.Where(p => p.Price > 3000).FirstOrDefault(); 
    (from p in products
     where p.Price > 3000
     select p).FirstOrDefault(); //?se lista vazia, retorna null
System.Console.WriteLine("First test1: " + r7);
System.Console.WriteLine();

var r15 = //products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
    (from p in products
     where p.Category.Id == 1
     select p.Price).Aggregate((x, y) => x + y);
System.Console.WriteLine("Aggregate: " + r15);
System.Console.WriteLine();

var r17 =
    from p in products
    group p by p.Category;
foreach (IGrouping<Category, Product> group in r17)
{
    System.Console.WriteLine($"Group key: {group.Key.Name}:");
    foreach (Product prod in group)
    {
        System.Console.WriteLine($"---Prod: {prod.Name}");
    }
    System.Console.WriteLine();
}