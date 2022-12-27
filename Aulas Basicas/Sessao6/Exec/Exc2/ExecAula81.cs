class ExecAula81 {
    public static void executar(){
        System.Console.WriteLine("Size of the matriz: ");
        string[] entries = new String(Console.ReadLine()).Split(' ');
        int linhas = int.Parse(entries[0]);
        int colunas = int.Parse(entries[1]);
        int[,] matriz = new int[linhas, colunas];

        for(int i = 0; i < linhas; i++) {
            entries = new String(Console.ReadLine()).Split(' ');
            for (int j = 0; j < colunas; j++) {
                matriz[i, j] = int.Parse(entries[j]);
            }
        }
        System.Console.Write("Search for: ");
        int busca = int.Parse(new String(Console.ReadLine()));

        for(int i = 0; i < linhas; i++) {
            for(int j = 0; j < colunas; j++) {
                if(matriz[i,j] == busca) {
                    System.Console.WriteLine($"Position: {i}, {j}");
                    if (j > 0) {
                        System.Console.WriteLine($"Left: {matriz[i,j-1]}");
                    }
                    if (j < colunas -1) {
                        System.Console.WriteLine($"Right: {matriz[i,j+1]}");
                    }
                    if (i > 0) {
                        System.Console.WriteLine($"Up: {matriz[i-1,j]}");
                    }
                    if (i < linhas -1) {
                        System.Console.WriteLine($"Down: {matriz[i+1,j]}");
                    }                    
                }
            }
        }
    }
}