using System.Globalization;
using ExecSec6;

class Aumento {
    private static List<Funcionario> ListaFuncionarios() {
        List<Funcionario> funcionarios = new List<Funcionario>();
        
        System.Console.Write("How much employees will be registered? ");
        int qtd = int.Parse(Console.ReadLine() ?? "0");
        
        for(int i = 0; i < qtd; i++) {
            System.Console.WriteLine($"Employee #{i+1}");
            System.Console.Write("Id: ");
            int idNovo = int.Parse(Console.ReadLine() ?? "0");
            System.Console.Write("Nome: ");
            string nomeNovo = Console.ReadLine() ?? " ";
            System.Console.Write("Salary: ");
            double salaryNovo = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            Funcionario novoFunc = new Funcionario(idNovo, nomeNovo, salaryNovo);
            funcionarios.Add(novoFunc);
        }        

        return funcionarios;
    }

    private static void realizaAumento(List<Funcionario> funcionarios) {
        System.Console.Write("Enter the employee id that will have salary increase: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        
        Funcionario? func = funcionarios.Find(elemento => elemento.Id == id);
        if (func == null) {
            System.Console.WriteLine("This id does not exists.");
        } else {
            System.Console.Write("Enter de percentage: ");
            double percentual = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            func.Salary *= 1 + (percentual / 100.0);
        }
    }
    
    private static void apresentaListaAtualizada(List<Funcionario> funcionarios) {        
        System.Console.WriteLine("Updated list of employees:");
        foreach (Funcionario funcionario in funcionarios) {
            System.Console.WriteLine($"{funcionario.Id}, {funcionario.Nome}, {funcionario.Salary.ToString("F2", CultureInfo.InvariantCulture)}");            
        }
    }
    public static void executarAumento() {
        List<Funcionario> funcionarios = ListaFuncionarios();
        
        apresentaListaAtualizada(funcionarios);
        
        realizaAumento(funcionarios);
        
        apresentaListaAtualizada(funcionarios);
    }
}