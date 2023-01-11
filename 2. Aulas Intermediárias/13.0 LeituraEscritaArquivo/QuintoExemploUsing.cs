class QuintoExemploUsing {
    string basePath = @".\files\";    
    
    public QuintoExemploUsing(string arquivo) {
        main(basePath + arquivo);
    }

    private void main(string filePath) {
        try {
            using (StreamReader reader = File.OpenText(filePath)) {
                while (!reader.EndOfStream) {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        } catch (Exception e) {
            System.Console.WriteLine("Erro: " + e.Message);
        }
    }
}