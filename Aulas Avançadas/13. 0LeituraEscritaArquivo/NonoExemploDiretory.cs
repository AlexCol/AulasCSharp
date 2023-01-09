class NonoExemploDiretory {
    static string basePath = @".\files\";
    public static void main(string[] args) {
        try {
            IEnumerable<string> folders = Directory.EnumerateDirectories(basePath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS:");
            foreach (string folder in folders) {
                Console.WriteLine(folder);
                
                /* //!não usar dentro do laço, pois cada arquivo criado automaticamente alimenta a coleção, o que pode gerar laço infinito
                if (Directory.Exists(folder + @"\createdFolder")) {
                    Directory.Delete(folder + @"\createdFolder");
                } else {
                    Directory.CreateDirectory(folder + @"\createdFolder");
                }
                */
            }

            System.Console.WriteLine(folders.Count());
            string pasta = folders.First<string>();
            if (Directory.Exists(pasta + @"\createdFolder")) {
                    Directory.Delete(pasta + @"\createdFolder");
            } else {
                    Directory.CreateDirectory(pasta + @"\createdFolder");
            }
            System.Console.WriteLine(folders.Count());



            IEnumerable<string> files = Directory.EnumerateFiles(basePath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS:");
            foreach (string file in files) {
                Console.WriteLine(file);
            }

            //Directory.Delete(basePath + @"\subFolder\createdFolder", true);

        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}