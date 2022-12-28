namespace Entities;
class HourContract {
    private DateTime _date;
    private double _valuePerHour;
    private int _hours;

    public DateTime Date { get => _date; set => _date = value; }
    public double ValuePerHour { get => _valuePerHour; set => _valuePerHour = value; }
    public int Hours { get => _hours; set => _hours = value; }

    public HourContract(){
    }
    public HourContract(DateTime date, double valuePerHour, int hours) {
        Date = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }

    public double TotalValue() {
        return ValuePerHour * Hours;
    }
}