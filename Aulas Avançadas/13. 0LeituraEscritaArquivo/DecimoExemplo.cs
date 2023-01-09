class DecimoExemplo {
    static string basePath = @".\files\";
    static string fileName =  @"\fileExemp10.txt";
    public static void main(string[] args) {
        try {
            DirectoryInfo dir = new DirectoryInfo(basePath);
            if(Directory.Exists(dir + @"\temp\Exemp10Folder")) {
                //Directory.Delete(basePath + @"\temp\Exemp10Folder", true);
                Directory.Delete(basePath + @"\temp", true);
                System.Console.WriteLine("Deletou tudo.");                
            
            } else {                
                DirectoryInfo newDir = dir.CreateSubdirectory(@".\temp\Exemp10Folder");
                using(StreamWriter writer = File.AppendText(newDir + fileName)) {
                    for (int i = 0; i < 10; i++) {
                        writer.WriteLine($"Frase n {i+1}.");
                    }
                }
                using (StreamReader reader = File.OpenText(newDir + fileName)) {
                    while(!reader.EndOfStream) {
                        Console.WriteLine(reader.ReadLine());
                    }
                }
                
            }
        } catch (Exception e) {
            System.Console.WriteLine("Error: " + e.Message);
        }
        
    }
}