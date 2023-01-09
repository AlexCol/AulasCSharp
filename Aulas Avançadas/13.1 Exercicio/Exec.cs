using System.Globalization;

class Exec {
    private static StreamWriter? writer;
    private static StreamReader? reader;
    public void executa(string basePath, string fileName) {
        List<string> textoArquivo = new List<string>();
        textoArquivo.Add("TV LED, 1290.99, 1");
        textoArquivo.Add("Video Game Chair, 350.5, 3");
        textoArquivo.Add("Iphone X, 900, 2");
        textoArquivo.Add("Sansung Galaxy 9, 850, 2");

        try {            
            escreveArquivo(basePath, fileName, textoArquivo);
            textoArquivo = lerArquivo(basePath+fileName);
            trataTextoArquivo(textoArquivo);
            escreveArquivo(basePath+@"out\", "summary.csv", textoArquivo);
        } catch (Exception e) {
            Console.WriteLine("Erro geral: " + e.Message);
        }
    }

    private static void trataTextoArquivo(List<string> textoArquivo) {
        for (int linha = 0; linha < textoArquivo.Count; linha++) {
            string[] linhaCortada = textoArquivo[linha].Split(',');
            
            double total = double.Parse(linhaCortada[1], CultureInfo.InvariantCulture) * double.Parse(linhaCortada[2], CultureInfo.InvariantCulture);

            textoArquivo[linha] = $"{linhaCortada[0]}, {total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

    private static List<string> lerArquivo(string arquivo) {
        List<string> textoArquivo = new List<string>();
        using(reader = File.OpenText(arquivo)) {
            while(!reader.EndOfStream) {
                textoArquivo.Add(new String(reader.ReadLine()));
            }
        }
        return textoArquivo;
    }

    private static void escreveArquivo(string basePath, string fileName, List<string> textoArquivo) {
        if (!Directory.Exists(basePath)) {
            Directory.CreateDirectory(basePath);
        }    
        
        using(writer = File.CreateText(basePath+fileName)) {
            foreach (string linha in textoArquivo) {
                writer.WriteLine(linha);
            }
        }
    }
}

