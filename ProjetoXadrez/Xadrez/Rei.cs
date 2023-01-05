using tabuleiro;

namespace xadrez;
class Rei : Peca {
    public PartidaDeXadrez partida;
    public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor) {
        this.partida = partida;
    }

    public override string ToString() {
        return "K";
    }

    private bool testeTorreParaRoque(Posicao pos) {
        Peca p = tabuleiro.peca(pos);
        return (p != null && p is Torre && p.cor == this.cor && p.qtdeMovimentos == 0);
    }

    public override bool[,] movimentosPossiveis() {
        
        bool[,] mat = new bool[tabuleiro.colunas, tabuleiro.linhas];
        if (posicao == null) return mat;

        Posicao pos = new Posicao(0,0);

        //acima
        pos.definirValores(posicao.linha-1, posicao.coluna);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        //ne
        pos.definirValores(posicao.linha-1, posicao.coluna+1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        //direita
        pos.definirValores(posicao.linha, posicao.coluna+1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        //se
        pos.definirValores(posicao.linha+1, posicao.coluna+1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        //abaixo
        pos.definirValores(posicao.linha+1, posicao.coluna);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        //so
        pos.definirValores(posicao.linha+1, posicao.coluna-1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        //esquerda
        pos.definirValores(posicao.linha, posicao.coluna-1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        //no
        pos.definirValores(posicao.linha-1, posicao.coluna-1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }

        //!#jogada especial roque
        if (qtdeMovimentos == 0 && !partida.xeque) {
            //!#jogada especial roque pequeno
            Posicao posT1 = new Posicao(posicao.linha, posicao.coluna +3);
            if (testeTorreParaRoque(posT1)) {
                Posicao p1 = new Posicao(posicao.linha, posicao.coluna+1);
                Posicao p2 = new Posicao(posicao.linha, posicao.coluna+2);
                if (tabuleiro.peca(p1) == null && tabuleiro.peca(p2) == null) {
                    mat[posicao.linha, posicao.coluna+2] = true;
                }
            }
            //!#jogada especial roque grande
            Posicao posT2 = new Posicao(posicao.linha, posicao.coluna - 4);
            if (testeTorreParaRoque(posT1)) {
                Posicao p1 = new Posicao(posicao.linha, posicao.coluna-1);
                Posicao p2 = new Posicao(posicao.linha, posicao.coluna-2);
                Posicao p3 = new Posicao(posicao.linha, posicao.coluna-3);
                if (tabuleiro.peca(p1) == null && tabuleiro.peca(p2) == null && tabuleiro.peca(p3) == null) {
                    mat[posicao.linha, posicao.coluna-2] = true;
                }
            }
        }
        return mat;
    }
}