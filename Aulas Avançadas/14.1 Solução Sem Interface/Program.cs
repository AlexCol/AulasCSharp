using System.Globalization;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string model = new String(Console.ReadLine());

bool data_errada = false;
DateTime start = new DateTime();
DateTime finish = new DateTime();

do {
    try {
        Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
        start = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy HH:mm): ");
        finish = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        data_errada = false;
    } catch (FormatException) {
        Console.WriteLine("Data informada não é válida!");
        Console.WriteLine();
        data_errada = true;
    }
} while (data_errada);

Console.Write("Enter price per hour: ");
double hour = double.Parse(new String(Console.ReadLine()), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double day = double.Parse(new String(Console.ReadLine()), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day);

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);

