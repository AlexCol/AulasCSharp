using System; 
using System.Globalization;

class E1011 {

    public static void executar(string[] args) { 
        double PI = 3.14159;
        double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double raio);

        double volume = (4/3.0) * PI * Math.Pow(raio, 3);
        string volumeString = volume.ToString("F3", CultureInfo.InvariantCulture);

        Console.WriteLine("VOLUME = " + volumeString);
    }
}