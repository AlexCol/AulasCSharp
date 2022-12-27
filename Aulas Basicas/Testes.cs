using System.Globalization;
using Aulas;
using Cartesiado;

class Testes {
    public static void executar() {
        int idade = 32;
        double saldo = 10.35784;
        string saldoFormatado = saldo.ToString("F2", CultureInfo.InvariantCulture);
        string nome = "Maria";

        Console.WriteLine("{0} tem {1} anos e tem um saldo de R$ {2}", nome, idade, saldoFormatado);

        Console.WriteLine($"{nome} tem {idade} anos e tem um saldo de R$ {saldoFormatado}");

        double d1 = double.MaxValue / Math.Pow(10, 301);
        Console.WriteLine(d1);
        float f1 = (float)d1;
        Console.WriteLine(f1);



        MinhaClass mc = new MinhaClass("ale");
        mc.facaAlgo();

        MinhaClass mc2 = new MinhaClass {Idade = 32};
        System.Console.WriteLine(mc2.Nome);

        MinhaClass mc3 = new MinhaClass(32);
        System.Console.WriteLine($"{mc3.Nome} tem {mc3.Idade} anos.");

        MinhaClass mc4 = new MinhaClass("alex", 37);
        System.Console.WriteLine($"{mc4.Nome} tem {mc4.Idade} anos.");

        mc4.Altura = 5.5;
        System.Console.WriteLine($"{mc4.Nome} tem {mc4.Idade} anos e tem {mc4.Altura.ToString("F4", CultureInfo.InvariantCulture)} de altura.");


        int tam = 20;
        MinhaClass[] vect = new MinhaClass[tam];
        for (int i = 0; i < tam; i++){
            string nomeTemp = "nome"+i;
            int idadeTemp = i+15;
            double alturaTemp = ((i/20.0)+1) * 1.05;
            vect[i] = new MinhaClass(nomeTemp, idadeTemp);
            vect[i].Altura = alturaTemp;
        }
        foreach (MinhaClass item in vect) {
            System.Console.WriteLine($"{item.Nome} tem {item.Idade} anos e tem {item.Altura.ToString("F4", CultureInfo.InvariantCulture)} de altura.");
        }
        System.Console.WriteLine(vect.Count());
        System.Console.WriteLine(vect.Count(elemento => elemento.Idade % 2 == 0));

        foreach (MinhaClass item in vect.OrderBy(element => element.Idade * -1)) {
            System.Console.WriteLine($"{item.Nome} tem {item.Idade} anos e tem {item.Altura.ToString("F4", CultureInfo.InvariantCulture)} de altura.");
        }


        Params calc = new Params();

        double somaParams = calc.Somar(
            5, 6, 7, 8, 9, 8
        );
        System.Console.WriteLine($"Soma dos params: {somaParams}");



        Cachorro a = new Cachorro();
        //a.

        Point p;
        p.X = 10;
        p.Y = 20;
        System.Console.WriteLine(p);


        int? n1 = null;
        int n2 = n1 ?? 1;
        System.Console.WriteLine($"n2 vale: {n2}");
    }

    
    private static void paramRef(ref int x) {
        x = x * 3;
    }
    public static void testeRef() {
        int a = 10;
        System.Console.WriteLine(a);
        paramRef(ref a);
        System.Console.WriteLine(a);

    }

    private static void paramOut(int entrada, out int saida) {
        saida = entrada * 30;
    }
    public static void testeOut() {
        paramOut(10, out int a);
        System.Console.WriteLine(a);

    }    

    public static void listas() {
        List<int> lista = new List<int>();
        for (int i = 0; i < 10; i++) {
            lista.Add(i);
        }

        //lista.Clear(); //!limpa tudo
        
        /*
        List<int> lista2 = new List<int>();
        for (int i = 0; i < 10; i++) {
            lista2.Add(i+90);
        }
        lista.AddRange(lista2); //!adiciona uma lista no fim de outra
        */
        
        /*
        lista.Add(5);
        IEnumerable<int> lista2 = lista.Distinct(); //!remove duplicatas
        foreach (int item in lista2) {
            System.Console.WriteLine(item);
        }
        */
        /*
        IEnumerable<int> lista2 = lista.Where(elemento => elemento % 2 == 0); //!retorna elementos que respeitem o critério
        foreach (int item in lista2) {
            System.Console.WriteLine(item);
        }
        */


        lista.Insert(3, 999); //! insere na posicao o novo valor
        lista.Add(5);
        //lista.Remove(5); //! remove o primeiro que encontrar
        lista.RemoveAll(elemento => elemento == 5); //! remove todos que baterem o critério
        lista.RemoveAt(3);


        
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("Imprimindo lista:");
        foreach (int item in lista) {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("-------------------------");
        /*
        System.Console.WriteLine(
            lista.Find(element => element > 5)
        );

        System.Console.WriteLine(
            lista.FindIndex(element => element > 5)
        );

        System.Console.WriteLine();
        System.Console.WriteLine("-------------------------");
        System.Console.WriteLine("Imprimindo lista:");
        List<int> lista3 = lista.FindAll(elemento => elemento % 2 == 0);
        foreach (int item in lista3) {
            System.Console.WriteLine(item);
        }
        */


    }

}