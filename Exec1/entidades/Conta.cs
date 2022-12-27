using System.Globalization;
class Conta {
    private Cliente _cliente;
    private int _numeroConta;
    private double _saldo;

    public Conta(Cliente cliente, int numConta) {
        _cliente = cliente;
        _numeroConta = numConta;
    }
    public Conta(Cliente cliente, int numConta, double saldoInicial): this(cliente, numConta) {
        _saldo = saldoInicial;
    }

    public int NumeroConta { get => _numeroConta; private set => _numeroConta = value; }
    public double Saldo { get => _saldo; set => _saldo = value; }
    internal Cliente Cliente { get => _cliente; private set => _cliente = value; }    

    public void mostarConta() {
        System.Console.WriteLine("Dados da conta:");
        System.Console.WriteLine(this.ToString());
    }

    public override string ToString() {
        return $"Conta {this.NumeroConta}, Titular {this.Cliente.Nome}, Saldo R$ {this.Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}