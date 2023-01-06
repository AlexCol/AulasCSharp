class TerceiroExemplo {
    static string caminhoBase = @".\files\";
    public static void main(string[] args) {
        string arquivo1 = caminhoBase + "file1Exemp3.txt";
        StreamReader? streamReader = null;
        try {
            streamReader = File.OpenText(arquivo1);
            
            while (!streamReader.EndOfStream) {                
                string s = new String(streamReader.ReadLine());                
                Console.WriteLine(s);
            }

        } catch (IOException io) {
            Console.WriteLine("Erro:" + io.Message);
        } finally {
            if (streamReader != null)streamReader.Close();
        }
    }
}