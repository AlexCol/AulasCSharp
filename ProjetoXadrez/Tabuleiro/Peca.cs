namespace tabuleiro;
class Peca
{
    public Posicao posicao { get; set; }
    public Cor cor { get; set; }
    public int qtdeMovimentos { get; protected set; }
    public Tabuleiro tabuleiro { get; protected set; }

    public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
    {
        this.posicao = posicao;
        this.cor = cor;
        this.tabuleiro = tabuleiro;
        this.qtdeMovimentos = 0;
    }
}