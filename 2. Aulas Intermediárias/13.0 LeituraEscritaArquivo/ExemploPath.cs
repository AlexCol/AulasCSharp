class ExemploPath {
    static string basePath = @".\files\file1Exemp1.txt";
    public static void main(string[] args) {
        System.Console.WriteLine("----GetDirectoryName: " + Path.GetDirectoryName(basePath));

        System.Console.WriteLine("----DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
        System.Console.WriteLine("----PathSeparator: " + Path.PathSeparator);

        System.Console.WriteLine("----GetFullPath: " + Path.GetFullPath(basePath));

        System.Console.WriteLine("----GetFileName: " + Path.GetFileName(basePath));
        System.Console.WriteLine("----GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(basePath));
        System.Console.WriteLine("----GetExtension: " + Path.GetExtension(basePath));

        System.Console.WriteLine("----GetTempPath: " + Path.GetTempPath());
        
        //System.Console.WriteLine(Path.);

    }    
}