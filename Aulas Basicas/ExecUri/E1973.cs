using System;
using System.Collections.Generic;

class E1973 {

    public static void executar(string[] args) { 
        int nEstrelas, posAtual;
        bool impar;
        List<int> carneirosPorPlaneta = new List<int>();
        List<int> controleAtaques = new List<int>();
        
        int.TryParse(Console.ReadLine(), out nEstrelas);
        string? entrada = Console.ReadLine();

        if (entrada != null) {
            foreach (string item in entrada.ToString().Split(' ')) {
                carneirosPorPlaneta.Add(int.Parse(item));
                controleAtaques.Add(0);
            }
        }
        posAtual = 0;
        while(posAtual >= 0 && posAtual < nEstrelas) {
            impar = carneirosPorPlaneta[posAtual] % 2 == 1;
            
            controleAtaques[posAtual] = 1;
            carneirosPorPlaneta[posAtual] -= carneirosPorPlaneta[posAtual] > 0 ? 1 : 0;            

            if (impar) {
                posAtual++;
            } else {
                posAtual--;
            }
        }
        
        long atacados = 0;
        foreach (long item in controleAtaques) {
            atacados += item;
        }

        long sobras = 0;
        foreach (long item in carneirosPorPlaneta) {
            sobras += item;
        }
        Console.WriteLine(atacados + " " + sobras);
    }
}