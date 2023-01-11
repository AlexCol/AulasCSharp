class Circle : Shape
{
    private double _radius;

    public Circle(Color color, double radius) : base(color)
    {
        Radius = radius;
    }

    public double Radius { get => _radius; set => _radius = value; }
    
    public override double area()
    {
       return Math.PI * Math.Pow(Radius, 2);
    }
}