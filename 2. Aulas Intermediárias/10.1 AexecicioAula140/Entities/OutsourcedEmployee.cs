class OutsourcedEmployee : Employee
{
    private double _additionalCharge;

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public double AdditionalCharge { get => _additionalCharge; set => _additionalCharge = value; }

    public override double Payment()
    {
        return base.Payment() + AdditionalCharge * 1.1;
    }
}