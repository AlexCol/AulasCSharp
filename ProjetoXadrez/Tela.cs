using tabuleiro;
using xadrez;

namespace xadrez_console;
class Tela
{
    public static void imprimirTabuleiro(Tabuleiro tab) {
        for (int i = 0; i < tab.linhas; i++) {
            for (int j = 0; j < tab.colunas; j++) {
                if (j == 0) {
                    Console.Write($"{8-i} " );
                }
                if (tab.peca(i, j) == null) {
                    Console.Write("- ");
                } else {
                    //Console.Write(tab.peca(i, j) + " ");
                    Tela.imprimirPeca(tab.peca(i, j));
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
    }

    public static PosicaoXadrez lerPosicaoXadrex() {
        string s = new String(Console.ReadLine());
        char coluna = s[0];
        int linha = int.Parse(s[1] + "");
        return new PosicaoXadrez(coluna, linha);
    } 

    public static void imprimirPeca(Peca peca) {
        ConsoleColor aux = Console.ForegroundColor;
        if (peca.cor == Cor.Branca) {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(peca);
        } else {            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(peca);
            
        }
        Console.ForegroundColor = aux;
    }
}