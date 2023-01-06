using System.Runtime.CompilerServices;

class PrimeiroExemplo {
    public static void main(string[] args) {
        string caminhoBase = @".\files\";
        string sourcePath = caminhoBase + "file1Exemp1.txt";
        string targetPath = caminhoBase + "file2Exemp1.txt";

        try {            
            FileInfo fileInfo = new FileInfo(sourcePath);
            
            //?testa se diretorio existe, senão cria
            if (!Directory.Exists(caminhoBase)) {
                Directory.CreateDirectory(caminhoBase);
            }

            //?testa se arquivo existe, senão cria
            if (!File.Exists(targetPath)) {
                fileInfo.CopyTo(targetPath);
            }

            //? lê todas as linhas do arquivo
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string linha in lines) {
                Console.WriteLine(linha);
            }

            string caminhoEscrita = caminhoBase + "file3Exemp1.txt";
            if (File.Exists(caminhoEscrita.Replace(".txt", ".csv"))) {
                File.Delete(caminhoEscrita.Replace(".txt", ".csv"));
            }            
            
            //?apaga conteudo do arquivo e escreve por cima
            File.WriteAllLines(caminhoEscrita, lines);

            //?mantem o que foi escrito, e adiciona ao fim do arquivo
            File.AppendAllLines(caminhoEscrita, lines);

        } catch (IOException io) {
            Console.WriteLine("Erro: " +io.Message);
        }
        
    }
}