namespace ExecSec6;
class Funcionario {
    private int _id;
    private string _nome = new String("");
    private double _salary;


    public Funcionario(int id, string nome, double salary) {
        Id = id;
        Nome = nome;
        Salary = salary;
    }
    public int Id { get => _id; set => _id = value; }
    public string Nome { get => _nome; set => _nome = value; }
    public double Salary { get => _salary; set => _salary = value; }
}