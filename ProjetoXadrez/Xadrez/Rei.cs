using tabuleiro;

namespace xadrez;
class Rei : Peca
{
    public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
    }

    public override string ToString() {
        return "K";
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
        return mat;
    }
}