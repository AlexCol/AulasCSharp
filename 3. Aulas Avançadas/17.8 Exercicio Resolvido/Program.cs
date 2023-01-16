using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Course.Entities;

string path;
List<Product> products = new List<Product>();

Console.Clear();
Console.Write("Enter full file path: ");
path = @"./file/in.csv";
Console.WriteLine(path);

using (StreamReader reader = File.OpenText(path))
{
    while (!reader.EndOfStream)
    {
        string[] linha = reader.ReadLine().Split(',');
        Product p = new Product(
            linha[0],
            double.Parse(linha[1], CultureInfo.InvariantCulture)
        );
        products.Add(p);
    }

    double avgPrice = products.Average(p => p.Price);
    Console.WriteLine($"Average price: {avgPrice.ToString("F2", CultureInfo.InvariantCulture)}");

    //!LINQ com Lambda
    //var itens = products.Where(p => p.Price < avgPrice).OrderByDescending(p => p.Name).Select(p => p.Name);

    //!LINQ com sintaxe semelhante a SQL
    var itens =
        from p in products
        where p.Price < avgPrice
        orderby p.Name descending
        select p.Name;
    MyFunc.Print(itens);
}
