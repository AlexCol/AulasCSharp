namespace Exemplo1;
class Ex1Main
{
    public static void main(string[] args)
    {
        PrintService printService = new PrintService();
        Console.Write("Hor many values? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            printService.AddValue(x);
        }
        printService.Print();
        Console.WriteLine($"First: {printService.First()}");

    }
}