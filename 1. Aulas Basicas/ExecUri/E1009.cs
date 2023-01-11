using System; 
using System.Globalization;

class E1009 {

    public static void executar(string[] args) { 
        string nome;
        double salarioTotal;

        nome = new String(Console.ReadLine());        
        double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double salarioFixo);
        double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double totalVenda);

        salarioTotal = salarioFixo + (totalVenda * 0.15);

        Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
    }
}