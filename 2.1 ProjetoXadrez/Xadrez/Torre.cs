using tabuleiro;

namespace xadrez;
class Torre : Peca
{
    public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {
    }

    public override string ToString()
    {
        return "T";
    }

    public override bool[,] movimentosPossiveis()
    {
        
        bool[,] mat = new bool[tabuleiro.colunas, tabuleiro.linhas];
        if (posicao == null) return mat;

        Posicao pos = new Posicao(0,0);

        //acima
        pos.definirValores(posicao.linha-1, posicao.coluna);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                break;
            }
            pos.linha -= 1;
        }
        //abaixo
        pos.definirValores(posicao.linha+1, posicao.coluna);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                break;
            }
            pos.linha += 1;
        }
        //esquerda
        pos.definirValores(posicao.linha, posicao.coluna-1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                break;
            }
            pos.coluna -= 1;
        }
        //direita
        pos.definirValores(posicao.linha, posicao.coluna+1);
        while (tabuleiro.posicaoValida(pos) && podeMover(pos)) {
            mat[pos.linha, pos.coluna] = true;
            if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != this.cor) {
                break;
            }
            pos.coluna += 1;
        }
        
        return mat;
    }
}