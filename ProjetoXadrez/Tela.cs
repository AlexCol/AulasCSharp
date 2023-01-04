using tabuleiro;
using xadrez;

namespace xadrez_console;
class Tela
{
    public static void imprimirTabuleiro(Tabuleiro tab) {
        for (int i = 0; i < tab.linhas; i++) {
            Console.Write($"{8-i} " );
            for (int j = 0; j < tab.colunas; j++) {
                imprimirPeca(tab.peca(i, j));
            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
    }

    public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posisoesPossiveis) {
        ConsoleColor fundoOriginal = Console.BackgroundColor;
        ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

        for (int i = 0; i < tab.linhas; i++) {
            Console.Write($"{8-i} " );
            for (int j = 0; j < tab.colunas; j++) {
                if (posisoesPossiveis[i,j]) {
                    Console.BackgroundColor = fundoAlterado;
                }
                imprimirPeca(tab.peca(i, j));
                Console.BackgroundColor = fundoOriginal;
            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");        
    }    

    public static PosicaoXadrez lerPosicaoXadrex() {
        string s = new String(Console.ReadLine());
        validaPosicaoXadrezLida(s);
        char coluna = s[0];
        int linha = int.Parse(s[1] + "");
        return new PosicaoXadrez(coluna, linha);
    } 

    private static void validaPosicaoXadrezLida(string s) {
        if (s.Length == 0) {
            throw new TabuleiroException("Entrada vazia, favor informar uma posição!");
        }
        if (s[0] < 'a' || s[0] > 'h' || s[1] < '1' || s[1] > '8' || s.Length != 2) {
            throw new TabuleiroException("Posicao informada não existe!");
        }
    }

    public static void imprimirPeca(Peca peca) {
        if (peca == null) {
            Console.Write("-");
        } else {
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
        Console.Write(" ");
    }
}