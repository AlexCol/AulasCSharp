using System.Globalization;

namespace tabuleiro;
abstract class Peca
{
    public Posicao? posicao { get; set; }
    public Cor cor { get; set; }
    public int qtdeMovimentos { get; protected set; }
    public Tabuleiro tabuleiro { get; protected set; }

    public Peca(Tabuleiro tabuleiro, Cor cor)
    {
        this.posicao = null;
        this.cor = cor;
        this.tabuleiro = tabuleiro;
        this.qtdeMovimentos = 0;
    }

    public void incrementaQteMovimentos() {
        qtdeMovimentos++;
    }
    public void decrementaQteMovimentos() {
        qtdeMovimentos--;
    }    

    public abstract bool[,] movimentosPossiveis();

    public bool existeMovimentosPossiveis() {
        bool[,] mat = movimentosPossiveis();
        for (int i = 0; i < tabuleiro.linhas; i++) {
            for (int j = 0; j < tabuleiro.colunas; j++) {
                if (mat[i,j]) {
                    return true;
                }
            }
        }
        return false;
    }

    public bool movimentoPossivel(Posicao pos) {
        return movimentosPossiveis()[pos.linha, pos.coluna];
    }

    protected virtual bool podeMover(Posicao pos) {
        Peca p = tabuleiro.peca(pos);
        return (p == null || p.cor != this.cor);
    }
}