class SextoExemploWriter {
    string basePath = @".\files\";
    
    public SextoExemploWriter(string arquivo) {
        main(basePath + arquivo);
    }

    private void main(string filePath) {
        try {
            if (Directory.Exists(basePath)) { 
                if (File.Exists(filePath)) {
                    File.Delete(filePath);
                    Console.WriteLine("Arquivo deletado!!");
                }
            }

            using (StreamWriter writer = File.AppendText(filePath)) {
                writer.WriteLine("Gravando dados.");
                writer.WriteLine("Gravando dados2.");
                writer.WriteLine("Gravando dados3.");
            }

        } catch (Exception e) {
            System.Console.WriteLine("Erro: " + e.Message);
        }
    }
}