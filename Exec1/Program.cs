int numConta;
double saldoInicial;
string nome;
Cliente cliente;
Conta conta;

Console.Clear();

System.Console.Write("Entre o numero da conta: ");
int.TryParse(Console.ReadLine(), out numConta);

System.Console.Write("Entre o titular da conta: ");
nome = new String(Console.ReadLine());

saldoInicial = Operacoes.temSaldoInicial();

cliente = new Cliente(nome);
conta = saldoInicial > 0 ? new Conta(cliente, numConta, saldoInicial) : new Conta(cliente, numConta);

conta.mostarConta();
Operacoes.deposito(conta);
Operacoes.saque(conta);
