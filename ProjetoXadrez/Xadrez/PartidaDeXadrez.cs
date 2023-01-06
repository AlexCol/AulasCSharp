using System.Numerics;
using System.Security.Cryptography;
using tabuleiro;

namespace xadrez;
class PartidaDeXadrez
{
    public Tabuleiro tab { get; private set; }
    public bool terminada { get; private set; }
    public int turno { get; private set; }
    public Cor jogadorAtual { get; private set; }
    private HashSet<Peca> pecas;
    private HashSet<Peca> capturadas;
    public bool xeque { get; private set; }
    public Peca? vulneravelEnPassant { get; private set; }
    public PartidaDeXadrez() {
        tab = new Tabuleiro(8, 8);
        turno = 1;
        jogadorAtual = Cor.Branca;
        terminada = false;
        xeque = false;
        vulneravelEnPassant = null;
        pecas = new HashSet<Peca>();
        capturadas = new HashSet<Peca>();
        colocarPecas();
    }

    public void realizaJogada(Posicao origem, Posicao destino) {
        Peca? pecaCapturada = executaMovimento(origem, destino);
        if (estaEmXeque(jogadorAtual)) {
            desfazMovimento(origem, destino, pecaCapturada);
            throw new TabuleiroException("Você não pode se colocar em xeque!");
        }

        if (estaEmXeque(adversaria(jogadorAtual))) {
            xeque = true;
        } else {
            xeque = false;
        }

        if(testeXequeMate(adversaria(jogadorAtual))) {
            terminada = true;
        } else {
            turno++;
            mudaJogador();
        }

        Peca p = tab.peca(destino);
        //! #jogada especial en passant
        if (p is Peao && destino.linha == origem.linha-2 || destino.linha == origem.linha+2) {
            vulneravelEnPassant = p;
        } else {
            vulneravelEnPassant = null;
        }
    }

    public void validarPosicaoDeOrigem(Posicao pos) {
        if (tab.peca(pos) == null) {
            throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
        }
        if (jogadorAtual != tab.peca(pos).cor) {
            throw new TabuleiroException("A peça de origem escolhida não é sua!");
        }
        if (!tab.peca(pos).existeMovimentosPossiveis()) {
            throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
        }
    }

    public void validarPosicaoDeDestino(Posicao origem, Posicao destino) {
        if (!tab.peca(origem).movimentoPossivel(destino)) {
            throw new TabuleiroException("Popsição de destino invalida!");
        }
    }
    
    public HashSet<Peca> pecasCapturadas(Cor cor) {
        HashSet<Peca> aux = new HashSet<Peca>();
        foreach (Peca peca in this.capturadas) {
            if(peca.cor == cor) {
                aux.Add(peca);
            }
        }
        return aux;
    }

    private Peca? executaMovimento(Posicao origem, Posicao destino) {
        Peca? p = tab.retirarPeca(origem);
        if (p != null) {
            p.incrementaQteMovimentos();
            Peca? pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            if (pecaCapturada != null) {
                capturadas.Add(pecaCapturada);
            }
            
            //!#jogada especial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna+2) {
                Posicao origemDaTorre = new Posicao(origem.linha, origem.coluna+3);
                Posicao destinoDaTorre = new Posicao(origem.linha, origem.coluna+1);
                Peca? T = tab.retirarPeca(origemDaTorre);
                if (T != null) {
                    T.incrementaQteMovimentos();
                    tab.colocarPeca(T, destinoDaTorre);
                }
            }
            //!#jogada especial roque grande
            if (p is Rei && destino.coluna == origem.coluna-2) {
                Posicao origemDaTorre = new Posicao(origem.linha, origem.coluna-4);
                Posicao destinoDaTorre = new Posicao(origem.linha, origem.coluna-1);
                Peca? T = tab.retirarPeca(origemDaTorre);
                if (T != null) {
                    T.incrementaQteMovimentos();
                    tab.colocarPeca(T, destinoDaTorre);
                }
            }

            //!#jogada especial en passant
            if (p is Peao) {                
                if (origem.coluna != destino.coluna && pecaCapturada == null) {                    
                    Posicao posPeaoCapturado;
                    if (p.cor == Cor.Branca) {
                        posPeaoCapturado = new Posicao(destino.linha + 1, destino.coluna);
                    } else {
                        posPeaoCapturado = new Posicao(destino.linha - 1, destino.coluna);
                    }
                    pecaCapturada = tab.retirarPeca(posPeaoCapturado);
                    if (pecaCapturada != null) {
                        capturadas.Add(pecaCapturada);
                    }
                }
            }

            return pecaCapturada;
        }
        return null;
    }

    private void desfazMovimento(Posicao origem, Posicao destino, Peca? pecaCapturada) {
        Peca? p = tab.retirarPeca(destino);
        if (p != null) {
            p.decrementaQteMovimentos();
            if (pecaCapturada != null) {
               tab.colocarPeca(pecaCapturada, destino);
               capturadas.Remove(pecaCapturada);
            }
            tab.colocarPeca(p, origem);

            //!#jogada especial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna+2) {
                Posicao origemDaTorre = new Posicao(origem.linha, origem.coluna+3);
                Posicao destinoDaTorre = new Posicao(origem.linha, origem.coluna+1);
                Peca? T = tab.retirarPeca(destinoDaTorre);
                if (T != null) {
                    T.decrementaQteMovimentos();
                    tab.colocarPeca(T, origemDaTorre);
                }
            }
            //!#jogada especial roque grande
            if (p is Rei && destino.coluna == origem.coluna-2) {
                Posicao origemDaTorre = new Posicao(origem.linha, origem.coluna-4);
                Posicao destinoDaTorre = new Posicao(origem.linha, origem.coluna-1);
                Peca? T = tab.retirarPeca(destinoDaTorre);
                if (T != null) {
                    T.decrementaQteMovimentos();
                    tab.colocarPeca(T, origemDaTorre);
                }
            }    

            //!#jogada especial en passant
            if (p is Peao) {                
                if (origem.coluna != destino.coluna && pecaCapturada == vulneravelEnPassant) {                    
                    Peca? peao = tab.retirarPeca(destino);
                    Posicao posPeao;
                    if (p.cor == Cor.Branca) {
                        posPeao = new Posicao(3, destino.coluna);
                    } else {
                        posPeao = new Posicao(4, destino.coluna);
                    }
                }
            }
            
        }
    }

    private void mudaJogador() {
        if (jogadorAtual == Cor.Branca) {
            jogadorAtual = Cor.Preta;
        } else {
            jogadorAtual = Cor.Branca;
        }
    }

    private HashSet<Peca> pecasEmJogo(Cor cor) {
        HashSet<Peca> aux = new HashSet<Peca>();
        foreach (Peca peca in this.pecas) {
            if(peca.cor == cor) {
                aux.Add(peca);
            }
        }
        aux.ExceptWith(pecasCapturadas(cor));
        return aux;
    }

    private Cor adversaria(Cor cor) {
        if (cor == Cor.Branca) {
            return Cor.Preta;
        } else {
            return Cor.Branca;
        }
    }

    private Peca? rei(Cor cor) {
        foreach (Peca peca in pecasEmJogo(cor)) {
            if(peca is Rei) {
                return peca;
            }
        }
        return null;
    }

    private bool testeXequeMate(Cor cor) {
        if (!estaEmXeque(cor)) {
            return false;
        }
        
        foreach (Peca peca in pecasEmJogo(cor)) {
            bool[,] mat = peca.movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (mat[i,j] && peca.posicao != null) {
                        Posicao origem = peca.posicao;
                        Posicao destino = new Posicao(i, j);
                        Peca? pecaCapturada = executaMovimento(origem, destino);
                        bool testeXeque = estaEmXeque(cor);
                        desfazMovimento(origem, destino, pecaCapturada);
                        if (!testeXeque) {
                            return false;
                        }
                    }
                }                
            }
        }
        return true;
    }

    private bool estaEmXeque(Cor cor) {
        Peca? r = rei(cor);
        if (r == null || r.posicao == null) {
            throw new TabuleiroException($"Não tem rei da cor {cor} no tabuleiro!");
        }
        foreach (Peca peca in pecasEmJogo(adversaria(cor))) {
            bool[,] mat = peca.movimentosPossiveis();
            if (mat[r.posicao.linha, r.posicao.coluna]) {
                return true;
            }
        }
        return false;
    }

    private void colocarNovaPeca(char coluna, int linha, Peca peca) {
        tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
        pecas.Add(peca);
    }
    private void colocarPecas() {
        colocarNovaPeca('a', 2, new Peao(tab, Cor.Branca, this));
        colocarNovaPeca('b', 2, new Peao(tab, Cor.Branca, this));
        colocarNovaPeca('c', 2, new Peao(tab, Cor.Branca, this));
        colocarNovaPeca('d', 2, new Peao(tab, Cor.Branca, this));        
        colocarNovaPeca('e', 2, new Peao(tab, Cor.Branca, this));
        colocarNovaPeca('f', 2, new Peao(tab, Cor.Branca, this));
        colocarNovaPeca('g', 2, new Peao(tab, Cor.Branca, this));
        colocarNovaPeca('h', 2, new Peao(tab, Cor.Branca, this));
        colocarNovaPeca('a', 1, new Torre(tab, Cor.Branca));
        colocarNovaPeca('h', 1, new Torre(tab, Cor.Branca));
        colocarNovaPeca('c', 1, new Bispo(tab, Cor.Branca));
        colocarNovaPeca('f', 1, new Bispo(tab, Cor.Branca));
        colocarNovaPeca('b', 1, new Cavalo(tab, Cor.Branca));
        colocarNovaPeca('g', 1, new Cavalo(tab, Cor.Branca));
        colocarNovaPeca('d', 1, new Rainha(tab, Cor.Branca));
        colocarNovaPeca('e', 1, new Rei(tab, Cor.Branca, this));
        //!        
        colocarNovaPeca('a', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('b', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('c', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('d', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('e', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('f', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('g', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('h', 7, new Peao(tab, Cor.Preta, this));
        colocarNovaPeca('a', 8, new Torre(tab, Cor.Preta));
        colocarNovaPeca('h', 8, new Torre(tab, Cor.Preta));
        colocarNovaPeca('c', 8, new Bispo(tab, Cor.Preta));
        colocarNovaPeca('f', 8, new Bispo(tab, Cor.Preta));
        colocarNovaPeca('b', 8, new Cavalo(tab, Cor.Preta));
        colocarNovaPeca('g', 8, new Cavalo(tab, Cor.Preta));
        colocarNovaPeca('d', 8, new Rainha(tab, Cor.Preta));
        colocarNovaPeca('e', 8, new Rei(tab, Cor.Preta, this));
    }

}