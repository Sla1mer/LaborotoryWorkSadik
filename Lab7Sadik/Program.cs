// Средний уровень - Вариант 17

try
{
    Console.Write("Введите k: ");
    int k = int.Parse(Console.ReadLine());

    double sum = 0;
    double mult = 1;

    for (int i = -3; i <= k; i++)
    {
        if (i != 5) 
        {
            sum += (Math.Pow(-1, i)) / (Math.Pow(i - 5, 2));        
        }

        for (int n = i; n <= 2 * k; n++)
        {
            if (n != -4 && n != 0 && Math.Pow(n, 3) != 8)
            {
                mult *= (Math.Pow(n, 3) - 8) / (n + 4);
            }
        }
    }

    Console.WriteLine($"W = {sum * mult:F2}");
} catch(Exception e)
{
    Console.WriteLine(e.Message);
}