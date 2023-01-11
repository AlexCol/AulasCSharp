namespace Aulas;
class MinhaClass {
    private string nome;
    private int idade;
    private double altura;

    public MinhaClass() {
        this.nome = "john doe";
    }
    public MinhaClass(string nome) {
        this.nome = nome;
        this.idade = 0;
    }

    public MinhaClass(int _idade) : this() {
        idade = _idade;
    }

    public MinhaClass(string _nome, int _idade) : this(_nome) {
        idade = _idade;
    }

    public string Nome { get => nome; set => nome = value; } //!Forma 1 de declarar gets e sets

    //!Forma 2 de declarar gets e sets
    public int Idade {
        get {
            return idade;
        }
        set {
            if (value > 10) {
                idade = value;
            }
        }
    }

    //!Forma 3 de declarar gets e sets (mas gera warning pq não explicitamente chama o atributo, ai o compilador acha que ele nunca foi usado)
    //public double Altura{get; set;} //?comentado pra parar os warning
    public double Altura { get => altura; set => altura = value; }

    
    public void facaAlgo() {
        facaAlgo(null);
    }
    
    public void facaAlgo(int? i) {
        nome = "ale";
    }

}

