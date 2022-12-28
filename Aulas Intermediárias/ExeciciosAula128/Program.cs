using System.Globalization;
using System.Runtime.ConstrainedExecution;
using Entities;
using Entities.Enums;

Department department;
string name;
WorkerLevel level;
double baseSalary;
Worker worker;
int qtdContracts;

Console.Clear();

System.Console.Write("Enter department's name: ");
department = new Department(Console.ReadLine() ?? " ");

System.Console.WriteLine("Enter worker data: ");
System.Console.Write("Name: ");
name = new String(Console.ReadLine());

System.Console.Write("Level (Junior/MidLevel/Senior): ");
Enum.TryParse<WorkerLevel>(Console.ReadLine(), out level);

System.Console.Write("Base salary: ");
baseSalary = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

worker = new Worker(name, level, baseSalary, department);

System.Console.Write("How many contracts to this worker? ");
int.TryParse(Console.ReadLine(), out qtdContracts);

for(int i = 0; i < qtdContracts; i++) {
    System.Console.WriteLine($"Enter {i+1}# contract data: ");
    
    System.Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    System.Console.Write("Value per hour: ");
    double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double valuePerHour);

    System.Console.Write("Duration (hours): ");
    int.TryParse(Console.ReadLine(), out int hours);

    worker.AddContract(new HourContract(date, valuePerHour, hours));
}

System.Console.WriteLine();
System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = new String(Console.ReadLine());

System.Console.WriteLine($"Name: {worker.Name}");
System.Console.WriteLine($"Department: {worker.Department.Name}");

//!System.Console.WriteLine($"Income for {monthAndYear}: {worker.Income(int.Parse(monthAndYear.Split('/')[1]), int.Parse(monthAndYear.Split('/')[0])).ToString("F2", CultureInfo.InvariantCulture)}");
int month = int.Parse(monthAndYear.Split('/')[0]);
int year = int.Parse(monthAndYear.Split('/')[1]);
double income = worker.Income(year, month);
System.Console.WriteLine($"Income for {monthAndYear}: {income.ToString("F2", CultureInfo.InvariantCulture)}");