using Lab16SadikLibrary;

try
{
    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine());
    
    Console.Write("Введите m: ");
    int m = int.Parse(Console.ReadLine());
    
    int[,] matrix = Class1.GenerateMatrix(n, m);
    double[] vector = Class1.CalculateVector(matrix);
    int result = Class1.CalculateResult(vector);

    Console.WriteLine("Матрица:");
    Class1.PrintMatrix(matrix);

    Console.WriteLine("\nВектор:");
    Class1.PrintVector(vector);

    Console.WriteLine($"\nПроизведение квадратов индексов максимального и минимального элементов вектора: {result}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}