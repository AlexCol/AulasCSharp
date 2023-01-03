using tabuleiro;
using xadrez;
using xadrez_console;

try 
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    
    while (!partida.terminada) {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrex().toPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrex().toPosicao();

        partida.executaMovimento(origem, destino);

    };


} catch (TabuleiroException t) {
    System.Console.WriteLine(t.Message);
}






Console.ReadLine();

