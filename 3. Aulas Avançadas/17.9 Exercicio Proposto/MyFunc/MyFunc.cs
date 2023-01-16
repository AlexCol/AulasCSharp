using System;
using System.Collections.Generic;

abstract class MyFunc
{
    public static void Print<T>(IEnumerable<T> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}