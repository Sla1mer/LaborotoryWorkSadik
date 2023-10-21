try
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());

    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine());

    double sum = 0;

    for (int i = 1; i <= n; i++)
    {
        sum += Math.Cos(i * 2 * x) / 3 + 8 * (n - 1);
    }

    Console.WriteLine($"Сумма: {sum:F2}");
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}