using System;
using System.Collections.Generic;

abstract class MyFunc
{
    public static void Print<T>(IEnumerable<T> lista)
    {
        foreach (T item in lista)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}