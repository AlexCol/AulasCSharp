class Employee
{
    private string _name;
    private int _hours;
    private double _valuePerHour;

    public Employee()
    {
        _name = new String("");
    }

    public Employee(string name, int hours, double valuePerHour) : this()
    {
        Name = name;
        Hours = hours;
        ValuePerHour = valuePerHour;
    }

    public string Name { get => _name; set => _name = value; }
    public int Hours { get => _hours; set => _hours = value; }
    public double ValuePerHour { get => _valuePerHour; set => _valuePerHour = value; }

    public virtual double Payment() {
        return Hours * ValuePerHour;
    }
}