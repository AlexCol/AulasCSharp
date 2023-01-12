namespace Exemp1;
class Exemp1Main
{
    public static void main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();
        set.Add("TV");
        set.Add("Notbook");
        set.Add("Tablet");

        Console.WriteLine(set.Contains("Tablt"));
        Console.WriteLine(set.Contains("Tablet"));

        Console.WriteLine("-----------");
        foreach (string produto in set)
        {
            Console.WriteLine(set.Contains(produto));
            Console.WriteLine(produto);
        }
        Console.WriteLine("-----------");
        PrintCollection.Print(set);

    }
}