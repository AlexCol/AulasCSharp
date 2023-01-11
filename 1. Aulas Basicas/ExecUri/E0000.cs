using System; 

class E0000 {

    public static void executar(string[] args) { 
        List<List<int>> matriz = new List<List<int>>();
        for (int i = 0; i < 10; i++) {
            matriz.Add(new List<int>());
            for (int j = 0; j < 10; j++) {
                matriz[i].Add(i+j);
            }
        }

        foreach (List<int> linha in matriz) {
            foreach(int item in linha) {
                Console.Write((item.ToString().PadLeft(3, ' ')));
            }
            Console.WriteLine("");
        }        
    }
}