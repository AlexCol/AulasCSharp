class MinhaSolucao
{
    public static void main()
    {
        Console.Write("Enter file full path: ");
        string path = @".\file\input.txt";
        Console.WriteLine(path);
        Dictionary<string, int> resultado = new Dictionary<string, int>();

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    string candidato = linha.Split(',')[0];
                    int votos = int.Parse(linha.Split(',')[1]);
                    if (resultado.ContainsKey(candidato))
                    {
                        resultado[candidato] += votos;
                    }
                    else
                    {
                        resultado[candidato] = votos;
                    }
                }
            }

            foreach (KeyValuePair<string, int> candidato in resultado)
            {
                Console.WriteLine($"{candidato.Key}: {candidato.Value}");
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Erro: " + e.Message);
        }
    }
}