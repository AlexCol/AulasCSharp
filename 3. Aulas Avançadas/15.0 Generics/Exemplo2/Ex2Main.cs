namespace Exemplo2;
class Ex2Main
{
    private static int n;
    public static void main(string[] args)
    {
        PrintService<int> printServiceInt = new PrintService<int>();
        Console.Write("Hor many values? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            printServiceInt.AddValue(x);
        }
        printServiceInt.Print();
        Console.WriteLine($"First: {printServiceInt.First()}");

        PrintService<string> printServiceString = new PrintService<string>();
        Console.Write("Hor many values? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();
            printServiceString.AddValue(x);
        }
        printServiceString.Print();
        Console.WriteLine($"First: {printServiceString.First()}");

    }
}