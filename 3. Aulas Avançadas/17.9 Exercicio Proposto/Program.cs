using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

string path;
double salary;
List<Employee> lista = new List<Employee>();

Console.Clear();
Console.Write("Enter full file path: ");
path = @"./file/funcionarios.csv";
Console.WriteLine(path);

using (StreamReader reader = File.OpenText(path))
{
    while (!reader.EndOfStream)
    {
        string[] campos = reader.ReadLine().Split(',');
        Employee e = new Employee(
            campos[0],
            campos[1],
            double.Parse(campos[2], CultureInfo.InvariantCulture)
        );
        lista.Add(e);
    }
}

Console.Write("Enter salary: ");
salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}:");

//!LINQ com lambda
//var emails = lista.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select(e => e.Email);

//!LINQ com sintaxe semelhante a sql
var emails =
    from e in lista
    where e.Salary > salary
    orderby e.Email
    select e.Email;
MyFunc.Print(emails);


//!forma 1
//var soma = lista.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

//!forma 2
//var soma = lista.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();

//!forma 3
//var soma = lista.Sum(e => e.Name[0] == 'M' ? e.Salary : 0);

//!forma 4
var soma =
    (from e in lista
     where e.Name[0] == 'M'
     select e.Salary).Sum();
Console.WriteLine($"Sum of salary of people whose name starts with 'M': {soma.ToString("F2", CultureInfo.InvariantCulture)}");

