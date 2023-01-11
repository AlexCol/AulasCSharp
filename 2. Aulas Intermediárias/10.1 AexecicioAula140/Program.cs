// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

int qtdEmployees;
List<Employee> emploList = new List<Employee>();

System.Console.Write("Enter the number of employess: ");
qtdEmployees = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < qtdEmployees; i++) {
    System.Console.WriteLine($"Employee {i+1} data:");
    System.Console.Write("Outsourced (y/n)? ");
    bool outsourced = new String(Console.ReadLine()).ToUpper().Equals("Y");

    System.Console.Write("Name: ");
    string name = new String(Console.ReadLine());

    System.Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine() ?? "0");

    System.Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

    if (outsourced) {
        System.Console.Write("Adicional charge: ");
        double adicional = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);        
        emploList.Add(new OutsourcedEmployee(name, hours, valuePerHour, adicional));
    } else {
        emploList.Add(new Employee(name, hours, valuePerHour));
    }
}

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("PAYMENTS: ");
foreach (Employee employee in emploList)
{
    System.Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}




