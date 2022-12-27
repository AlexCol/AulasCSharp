using System.Globalization;

static class Operacoes {

    private static void apresentarDadosAtualizados(Conta conta) {
        System.Console.WriteLine("Dados da conta atualizados:");
        System.Console.WriteLine(conta.ToString());
        System.Console.WriteLine();
    }
    
    public static void deposito(Conta conta) {        
        System.Console.Write("Entre um valor para deposito: ");
        double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double entrada);
        conta.Saldo += entrada;
        apresentarDadosAtualizados(conta);
    }

    public static void saque(Conta conta) {
        System.Console.Write("Entre um valor para saque: ");
        double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double saque);
        conta.Saldo -= (saque + 5);
        apresentarDadosAtualizados(conta);
    }

    public static double temSaldoInicial() {
        string perguntaSaldo;
        double saldoInicial = 0;
        bool respostaInvalida;

        do {
            System.Console.Write("Haverá deposito inicial (s/n)? ");
            perguntaSaldo = new String(Console.ReadLine()).ToLower();
            
            respostaInvalida = !(perguntaSaldo.Equals("s") || perguntaSaldo.Equals("n"));
            if (respostaInvalida) {
                System.Console.WriteLine("Opção invalida. Tente novamente.");
            }
        } while (respostaInvalida);
        
        if (perguntaSaldo.Equals("s")) {
            System.Console.Write("Entre o valor de depósito inicial: ");
            double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out saldoInicial);
        }
        return saldoInicial;
    }
}