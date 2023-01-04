using tabuleiro;
using xadrez;
using xadrez_console;

try  {
    PartidaDeXadrez partida = new PartidaDeXadrez();
    
    while (!partida.terminada) {
        try{
            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab);

            Console.WriteLine();
            Console.WriteLine($"Turno: {partida.turno}");
            Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");

            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrex().toPosicao();
            partida.validarPosicaoDeOrigem(origem);

            Console.Clear();
            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();                        
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);        

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrex().toPosicao();
            partida.validarPosicaoDeDestino(origem, destino);

            System.Console.WriteLine(origem);
            partida.realizaJogada(origem, destino);
        } catch (TabuleiroException e) {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    };


} catch (TabuleiroException t) {
    System.Console.WriteLine(t.Message);
}

Console.ReadLine();

