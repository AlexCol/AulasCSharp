using tabuleiro;

namespace xadrez;
class Rainha : Peca {
    public Rainha(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {
    }

    public override string ToString() {
        return "Q";
    }

    public override bool[,] movimentosPossiveis() {
        bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
        if (posicao == null) return mat;
        Posicao pos = new Posicao(0, 0);

        // esquerda
        pos.definirValores(posicao.linha, posicao.coluna - 1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha, pos.coluna - 1);
        }

        // direita
        pos.definirValores(posicao.linha, posicao.coluna + 1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha, pos.coluna + 1);
        }

        // acima
        pos.definirValores(posicao.linha - 1, posicao.coluna);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha - 1, pos.coluna);
        }

        // abaixo
        pos.definirValores(posicao.linha + 1, posicao.coluna);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha + 1, pos.coluna);
        }

        // NO
        pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha - 1, pos.coluna - 1);
        }

        // NE
        pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha - 1, pos.coluna + 1);
        }

        // SE
        pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
        }

        // SO
        pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor) {
                break;
            }
            pos.definirValores(pos.linha + 1, pos.coluna - 1);
        }

        return mat;
    }

}