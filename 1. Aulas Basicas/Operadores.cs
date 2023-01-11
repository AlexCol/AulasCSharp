using System.Globalization;

class Operadores {
    string specifier = " ";
    CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");

    public void executar(string[] args) {
        Console.WriteLine(5 + 3 * 9);
        Console.WriteLine(4 % 2);

        double value = 5.123456789;
        Console.WriteLine(value);
       
        specifier = "F3";       
        Console.WriteLine("Usando "+specifier+": ");
        Console.WriteLine(value.ToString(specifier, CultureInfo.InvariantCulture));
        Console.WriteLine(value.ToString(specifier, culture));        
        Console.WriteLine(value.ToString(specifier));
        
        specifier = "F4";
        Console.WriteLine("Usando "+specifier+": ");
        Console.WriteLine(value.ToString(specifier, CultureInfo.InvariantCulture));
        
        specifier = "C";
        Console.WriteLine("Usando "+specifier+": ");
        Console.WriteLine(value.ToString(specifier, CultureInfo.InvariantCulture));
        Console.WriteLine(value.ToString(specifier, culture));

        Console.WriteLine("---------------------");
        Console.WriteLine(5 / 2);
        Console.WriteLine(5 / 2f);

        string frase = "Minha        Frase  é muito   legal.";
        foreach (
            //string palavra in frase.Split(" ").Where(elemento => elemento.Trim() != "")
            string palavra in frase.Split(" ").Where(elemento => elemento.Length >= 5)
        ) {
            Console.WriteLine(palavra);
        }

        int n1;
        bool deuCerto = int.TryParse(Console.ReadLine(), out n1);
        Console.WriteLine((deuCerto) ? n1 : "nao foi numero inteiro");

        double d1;
        deuCerto = double.TryParse(Console.ReadLine(), out d1);
        Console.WriteLine((deuCerto) ? d1+1 : "nao foi double");

        deuCerto = double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out d1);
        Console.WriteLine((deuCerto) ? d1+1 : "nao foi double");



    }
}