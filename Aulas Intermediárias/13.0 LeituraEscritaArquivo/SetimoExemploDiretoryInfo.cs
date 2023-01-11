class SetimoExemploDiretoryInfo {
    static string basePath = @".\files\";
    public static void main(string[] args) {
        try {
            DirectoryInfo dir = new DirectoryInfo(basePath);
            foreach(DirectoryInfo folder in dir.GetDirectories()) {
                Console.WriteLine("--Directory");
                Console.WriteLine(folder.Name);
                Console.WriteLine("--File(s):");
                foreach(FileInfo file in folder.GetFiles()) {                    
                    Console.WriteLine(file.Name);
                }
                Console.WriteLine("---");          
            }

            Console.WriteLine("--Main Dir File(s):");
            foreach(FileInfo file in dir.GetFiles()) {                    
                Console.WriteLine(file.Name);
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}