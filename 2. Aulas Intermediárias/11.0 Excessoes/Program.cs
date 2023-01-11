using System.Globalization;
using System.Runtime.ConstrainedExecution;

Console.Clear();
System.Console.WriteLine("Inicianto processo.");
double n1;
double n2;

for (int i = 0; i < 5; i++) {
    try {
        System.Console.WriteLine();
        System.Console.WriteLine($"Dentro do try com i = {i}");
        System.Console.Write("Digite um numero: ");
        n1 = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        System.Console.Write("Digite outro numero: ");
        n2 = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

        if (n2 == 0) {
            throw new DivideByZeroException();
        }
        if (n1 > 10 || n2 > 10) {
            throw new MinhaException("Mensagem personalizada 1.");
        }
        if (n1 == 9.5) {
            throw new MinhaException("Mensagem personalizada 2.");
        }

        System.Console.WriteLine($"n1 / n2 = {(n1/n2).ToString("F2", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine("Fim do try. Não deu erro.");
    }
    catch(MinhaException m) {
        System.Console.WriteLine($"meu erro: {m.Message}");
    }
    catch(DivideByZeroException d) {
        System.Console.WriteLine($"Deu erro de divisao por 0: {d.Message}");
    }
    catch (FormatException o) {
        System.Console.WriteLine($"Informado dado invalido: {o.Message}");
    }
    catch (Exception e) {
        System.Console.WriteLine($"Deu erroo: {e.StackTrace}");
    }
    finally {
        System.Console.WriteLine("Independente do que ocorrer, vai passar por aqui. Finnaly.");
    }
}
System.Console.WriteLine("Fim.");