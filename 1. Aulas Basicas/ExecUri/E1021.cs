using System; 
using System.Globalization;

class E1021 {

    public static void executar(string[] args) {                 
        int notas, moedas;
        double peso;
        double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double entrada);
        notas = (int)entrada;
        entrada -= notas;
        moedas = (int)(Math.Round(entrada, 2) * 100);
        
        Console.WriteLine("NOTAS:");
        peso = 100;
        while (peso >= 2) {
          Console.WriteLine((int)(notas/peso) + " nota(s) de R$ " + peso.ToString("F2", CultureInfo.InvariantCulture));
          notas -= (int)(notas/peso) * (int)peso;
          peso /= 2;
          peso = (peso == 25) ? 20 : (peso == 2.5) ? 2 : peso;
        }
        
        moedas += notas * 100;
        Console.WriteLine("MOEDAS:");
        peso = 100;
        while (peso >= 1) {
          Console.WriteLine((int)(moedas/peso) + " moeda(s) de R$ " + (peso/100).ToString("F2", CultureInfo.InvariantCulture));
          moedas -= (int)(moedas/peso) * (int)peso;
          peso /= 2;
          peso = (peso == 12.5) ? 10 : (peso == 2.5) ? 1 : peso;
        }
    }
}