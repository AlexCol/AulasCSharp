abstract class Shape
{
    private Color _color;

    protected Shape(Color color)
    {
        Color = color;
    }

    internal Color Color { get => _color; set => _color = value; }

    public abstract double area();
}