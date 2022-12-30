using System.Globalization;
using System.Reflection.PortableExecutable;

List<Shape> list = new List<Shape>();

Console.Clear();

System.Console.Write("Enter de number of shapes: ");
int.TryParse(Console.ReadLine(), out int qtdShapes);

for (int i = 0; i < qtdShapes; i++)
{
    System.Console.WriteLine($"Shape #{i+1} data:");
    System.Console.Write("Rectangle or Circle (r/c)? ");
    char.TryParse(Console.ReadLine(), out char shapeType);
    System.Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(new String(Console.ReadLine()));
    switch (shapeType) {
        case 'r':
            System.Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);
            System.Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);
            list.Add(new Rectangle(color, width, height));
            break;
        case 'c':
            System.Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine()??"0", CultureInfo.InvariantCulture);
            list.Add(new Circle(color, radius));
            break;
    }
}

System.Console.WriteLine();
System.Console.WriteLine("SHAPE AREAS:");
foreach (Shape shape in list)
{
    System.Console.WriteLine(shape.area().ToString("F2", CultureInfo.InvariantCulture));
}