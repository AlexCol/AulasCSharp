

Client a = new Client { Name = "Laura", Email = "laura@yahoo.com" };
Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

Console.WriteLine($"HashCode A: {a.GetHashCode()}");
Console.WriteLine($"HashCode B: {b.GetHashCode()}");

Console.WriteLine($"Equals? {a.Equals(b)}");
Console.WriteLine($"Iguais? {(a == b)}");



Client c = new Client { Name = "Pedro", Email = "pedro@yahoo.com" };
Client d = new Client { Name = "Pedro", Email = "pedro@yahoo.com" };

Console.WriteLine($"HashCode C: {c.GetHashCode()}");
Console.WriteLine($"HashCode D: {d.GetHashCode()}");

Console.WriteLine($"Equals? {c.Equals(d)}");
Console.WriteLine($"Iguais? {(c == d)}");