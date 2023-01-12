using System.Globalization;
using System.Linq.Expressions;

Console.Clear();

Console.Write("Enter full path: ");
//string path = Console.ReadLine();
string path = @".\file\input.txt";
Console.WriteLine(path);

HashSet<LogRecord> log = new HashSet<LogRecord>();
HashSet<string> listaUsers = new HashSet<string>();

try
{
    using (StreamReader reader = new StreamReader(path))
    {
        while (!reader.EndOfStream)
        {
            string linha = reader.ReadLine();
            string[] splited = linha.Split(' ');
            LogRecord novo = new LogRecord(splited[0], DateTime.Parse(splited[1]));
            log.Add(novo);
            listaUsers.Add(novo.UserName);
            Console.WriteLine(linha);
        }
        Console.WriteLine("Total logs: " + log.Count);
        Console.WriteLine("Total userLogs: " + listaUsers.Count);


        Console.WriteLine("---------------------------------------------------");
        SortedSet<LogRecord> sorted = new SortedSet<LogRecord>(log);
        PrintCollection.Print(log);
        Console.WriteLine("---------------------------------------------------");
        PrintCollection.Print(sorted);


    }
}
catch (Exception e)
{
    System.Console.WriteLine("Erro: " + e.Message);
}