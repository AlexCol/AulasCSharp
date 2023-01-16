using System.Runtime.ConstrainedExecution;

class MyFunc
{
    public static void Print<T>(string message, IEnumerable<T> collection)
    {
        System.Console.WriteLine(message);
        foreach (T item in collection)
        {
            System.Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}