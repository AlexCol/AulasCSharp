using tabuleiro;
using xadrez;
using xadrez_console;

Console.Clear();

Tabuleiro tab = new Tabuleiro(8, 8);

try 
{
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 9));
    
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

    Tela.imprimirTabuleiro(tab);
} catch (TabuleiroException t) {
    System.Console.WriteLine(t.Message);
}

//Console.ReadLine();

