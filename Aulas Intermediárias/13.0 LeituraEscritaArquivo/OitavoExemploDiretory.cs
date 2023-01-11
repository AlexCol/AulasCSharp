class OitavoExemploDiretory {
    static string basePath = @".\files\";
    public static void main(string[] args) {
        try {
            foreach(string folder in Directory.GetDirectories(basePath)) {
                Console.WriteLine("--Directory");
                Console.WriteLine(folder);
                Console.WriteLine("--File(s):");
                foreach(string file in Directory.GetFiles(folder)) {                    
                    Console.WriteLine(file);
                }
                Console.WriteLine("---");          
            }

            Console.WriteLine("--Main Dir File(s):");
            foreach(string file in Directory.GetFiles(basePath)) {
                Console.WriteLine(file);
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}