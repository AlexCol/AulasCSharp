class PrintCollection
{
    public static void Print<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.WriteLine(item);
        }
    }
}