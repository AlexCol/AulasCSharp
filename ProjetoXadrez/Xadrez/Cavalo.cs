using tabuleiro;

namespace xadrez;
class Cavalo : Peca {
    public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
    }

    public override string ToString() {
        return "C";
    }

    public override bool[,] movimentosPossiveis() {
        bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
        if (posicao == null) return mat;
        Posicao pos = new Posicao(0, 0);

        pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }
        pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
        if (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
        }

        return mat;
    }

}