using tabuleiro;
using xadrez;
using xadrez_console;

try  {
    PartidaDeXadrez partida = new PartidaDeXadrez();
    
    while (!partida.terminada) {
        try{
            Console.Clear();
            Tela.imprimirPartida(partida);
            
            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrex().toPosicao();
            partida.validarPosicaoDeOrigem(origem);

            Console.Clear();
            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();                        
            Tela.imprimirPartida(partida, posicoesPossiveis);
            
            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrex().toPosicao();
            partida.validarPosicaoDeDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        } catch (TabuleiroException e) {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    };
    Console.Clear();
    Tela.imprimirPartida(partida);

} catch (TabuleiroException t) {
    System.Console.WriteLine(t.Message);
}

Console.ReadLine();

