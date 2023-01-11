using System.Globalization;
using System.Runtime.ConstrainedExecution;

class DataHora {
    public static void MyDateTime(){
        DateTime d1 = new DateTime(2018, 1, 1);
        DateTime d2 = new DateTime(2022, 1, 2, 12, 30, 0);
        DateTime d3 = new DateTime(2022, 2, 2, 16, 35, 35, 500);
        DateTime d4 = DateTime.Now;
        DateTime d5 = DateTime.Today;
        DateTime d6 = DateTime.UtcNow;

        

        System.Console.WriteLine(d1);
        System.Console.WriteLine(d2);
        System.Console.WriteLine(d3);
        System.Console.WriteLine(d4);
        System.Console.WriteLine(d5);
        System.Console.WriteLine(d6);

        System.Console.WriteLine("-------------------------------------------------------------");
        DateTime d7 = DateTime.Parse("13/11/2022");
        System.Console.WriteLine(d7);
               
        DateTime d8 = DateTime.ParseExact("12-2022-15", "MM-yyyy-dd", CultureInfo.InvariantCulture);
        System.Console.WriteLine(d8);

        string data3Formatada = d3.ToString("yyyy-dd-MM HH:mm:ss");
        System.Console.WriteLine(d3);
        System.Console.WriteLine(data3Formatada);

    }

    public static void MyTimeSpan() {
        TimeSpan ts = new TimeSpan(1, 0, 0, 0);

        DateTime dt = DateTime.Now;

        System.Console.WriteLine(dt + ts);

        TimeSpan ts2 = new TimeSpan(1, 0, 0, 0);
        System.Console.WriteLine(ts2.Ticks);
        
        TimeSpan ts3 = TimeSpan.FromDays(1.5);
        System.Console.WriteLine(dt + ts3);

    }
}