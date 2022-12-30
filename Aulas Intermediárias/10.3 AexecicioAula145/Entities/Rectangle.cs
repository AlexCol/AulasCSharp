class Rectangle : Shape
{

    private double _width;
    private double _height;

    public Rectangle(Color color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    public double Width { get => _width; set => _width = value; }
    public double Height { get => _height; set => _height = value; }

    public override double area()
    {
        return Width * Height;
    }
}