using Entities.Enums;

namespace Entities;
class Worker {
    private string _name;
    private WorkerLevel _level;
    private double _baseSalary;
    private Department _department;
    private List<HourContract> _contracts;

    public Worker(){
        _name = new String("");
        _department = new Department("");
        _contracts = new List<HourContract>();
    }

    public Worker(string name, WorkerLevel level, double baseSalary, Department department) :this() {
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
        Department = department;
    }

    public string Name { get => _name; set => _name = value; }
    internal WorkerLevel Level { get => _level; set => _level = value; }
    public double BaseSalary { get => _baseSalary; set => _baseSalary = value; }
    internal Department Department { get => _department; set => _department = value; }
    internal List<HourContract> Contracts { get => _contracts; set => _contracts = value; }

    public void AddContract(HourContract contract) {
        Contracts.Add(contract);
    }
    public void RemoveContract(HourContract contract) {
        Contracts.Remove(contract);
    }
    public double Income(int year, int month) {
        double sum = this.BaseSalary;
        foreach (HourContract contract in Contracts) {
            if(contract.Date.Year == year && contract.Date.Month == month) {
                sum += contract.TotalValue();
            }
        }
        return sum;
    }

}