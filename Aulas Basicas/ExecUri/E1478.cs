using System; 
using System.Collections.Generic;

class E1478 {

    public static void executar(string[] args) { 
        int valorEntrada, controle;
        bool desce;
        List<int> entradas = new List<int>();

        do {
            int.TryParse(Console.ReadLine(), out valorEntrada);
            if (valorEntrada != 0) {
                entradas.Add(valorEntrada);
            }
        } while(valorEntrada != 0);

        foreach (int item in entradas) {
            for (int linha = 1; linha <= item; linha++) {
                controle = linha;
                desce = true;
                for (int coluna = 0; coluna < item; coluna++) {
                    if (coluna == item -1 ) {
                        Console.WriteLine(controle.ToString().PadLeft(3, ' '));
                    } else {
                        Console.Write(controle.ToString().PadLeft(3, ' ') + ' ');
                    }
                    controle += (desce) ? -1 : 1;
                    if (controle < 1) {
                        desce = false;
                        controle += 2;
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}