
using System.Globalization;
using System.Runtime.ConstrainedExecution;

try {
    System.Console.Write("Room number: ");
    int room = int.Parse(new String(Console.ReadLine()));
    System.Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    System.Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    
    Reservation r = new Reservation(room, checkIn, checkOut);
    System.Console.WriteLine(r.ToString());

    System.Console.WriteLine();
    System.Console.WriteLine("Enter data to update the reservation:");
    System.Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    System.Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    
    r.UpdateDates(checkIn, checkOut);
    System.Console.WriteLine(r.ToString());
} catch(ReservationException r) {
    System.Console.WriteLine("Error in reservation: "+ r.Message);
} catch(Exception e) {
    System.Console.WriteLine(e.Message);
}