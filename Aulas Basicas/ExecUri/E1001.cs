using System; 

class E1001 {

    public static void executar(string[] args) { 
        int a, b;
        int.TryParse(Console.ReadLine(), out a);
        int.TryParse(Console.ReadLine(), out b);
        Console.WriteLine("X = " + (a+b));
    }
}