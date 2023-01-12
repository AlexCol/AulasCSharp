namespace Exemp2;
class Exemp2Main
{
    public static void main(string[] args)
    {
        SortedSet<int> a = new SortedSet<int>() { 5, 6, 3, 2, 8, 7, 9 };
        SortedSet<int> b = new SortedSet<int>() { 1, 2, 3, 4, 9, 10 };

        //PrintCollection(a);
        //!Union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
        PrintCollection.Print(c);

        //!intersectio
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        PrintCollection.Print(d);

        //!diference
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        PrintCollection.Print(e);

        SortedSet<string> s = new SortedSet<string>() { "alex", "bernard", "violet", "alfred", "alfred" };
        PrintCollection.Print(s);
    }

    /*
    private static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.WriteLine(item);
        }
    }
    */
}