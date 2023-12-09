// Средний уровень 18

try
{
    Console.Write("Введите x1: ");
    int x1 = int.Parse(Console.ReadLine());
    
    Console.Write("Введите y1: ");
    int y1 = int.Parse(Console.ReadLine());
    
    Console.Write("Введите x2: ");
    int x2 = int.Parse(Console.ReadLine());
    
    Console.Write("Введите y2: ");
    int y2 = int.Parse(Console.ReadLine());

    Vector vector = new Vector(x1, y1, x2, y2);
    Console.WriteLine();
    Console.WriteLine("Середина вектора");
    vector.MiddleCoord();
    Console.WriteLine();
    Console.WriteLine($"Угол 45 градусов: {vector.is45Angle()}");
    Console.WriteLine();
    Console.WriteLine("Информация об объекте");
    vector.Print();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Vector
{
    private int x1;
    private int y1;
    private int x2;
    private int y2;

    public Vector()
    {
    }

    public Vector(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public int X1
    {
        get => x1;
        set => x1 = value;
    }

    public int Y1
    {
        get => y1;
        set => y1 = value;
    }

    public int X2
    {
        get => x2;
        set => x2 = value;
    }

    public int Y2
    {
        get => y2;
        set => y2 = value;
    }

    public void MiddleCoord()
    {
        Console.WriteLine( $"x: {(x1 + x2) / 2}");
        Console.WriteLine( $"y: {(y1 + y2) / 2}");
    }

    public bool is45Angle()
    {
        return Math.Atan((y2 - y1) / (x2 - x1)) == 45;
    }
    
    public void Print()
    {
        Console.WriteLine($"x1:{x1} y1:{y1}");
        Console.WriteLine($"x2:{x2} y2:{y2}");
    }
}