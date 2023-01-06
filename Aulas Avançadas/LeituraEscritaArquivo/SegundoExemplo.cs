class SegundoExemplo {
    static string caminhoBase = @".\files\";
    public static void main(string[] args) {
        string arquivo1 = caminhoBase + "file1Exemp2.txt";
        FileStream? fileStream = null;
        StreamReader? streamReader = null;
        try {
            fileStream = new FileStream(arquivo1, FileMode.Open);
            streamReader = new StreamReader(fileStream);
            string s = new String(streamReader.ReadLine());
            
            while (!s.Equals("")) {
                Console.WriteLine(s);
                s = new String(streamReader.ReadLine());                
            }
        } catch (IOException io) {
            Console.WriteLine("Erro:" + io.Message);
        } finally {
            if (fileStream != null) fileStream.Close();
            if (streamReader != null)streamReader.Close();
        }
    }
}