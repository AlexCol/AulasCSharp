using System; 
using System.Globalization;

class E1012 {

    public static void executar(string[] args) { 
        string[] entrada = new String(Console.ReadLine()).Split(' ');
        
        double.TryParse(entrada[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double a);
        double.TryParse(entrada[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double b);
        double.TryParse(entrada[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double c);

        double triangulo = (a * c) / 2;
        double circulo = 3.14159 * Math.Pow(c, 2);
        double trapezio = ((a + b) * c)/2;
        double quadrado = b * b;
        double retangulo = a * b;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }
}