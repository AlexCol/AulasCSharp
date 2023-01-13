using System.Globalization;

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
var r1 = products.Where(p => p.Price < 900 && p.Category.Tier == 1);
MyFunc.Print("TIER 1 AND PRICE < 900:", r1);

//IEnumerable<String> r2 = products.Where(p => p.Category.Name.Equals("Tools")).Select(p => p.Name);
var r2 = products.Where(p => p.Category.Name.Equals("Tools")).Select(p => p.Name);
MyFunc.Print("NAMES OD PRODUCTS FROM TOOLS:", r2);

var r3 = products.Where(p => p.Name[0] == 'C').Select(p => $"{p.Name}, {p.Price.ToString("F2", CultureInfo.InvariantCulture)}");
MyFunc.Print("NAMES AND PRICES OF PRODUCTS WITH NAME STATING WITH C", r3);