class QuartoExemploUsing {
    string basePath = @".\files\";    
    
    public QuartoExemploUsing(string arquivo) {
        main(basePath + arquivo);
    }

    private void main(string filePath) {
        try {
            using (FileStream fs = new FileStream(filePath, FileMode.Open)) {
                using (StreamReader reader = new StreamReader(fs)) {
                    while (!reader.EndOfStream) {
                        Console.WriteLine(reader.ReadLine());
                    }
                }
            }
        } catch (Exception e) {
            System.Console.WriteLine("Erro: " + e.Message);
        }
    }
}