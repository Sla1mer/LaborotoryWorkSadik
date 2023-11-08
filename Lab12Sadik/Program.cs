// Высокий уровень 
// Вариант 15

int n = int.Parse(Console.ReadLine());

int[,] mas = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j + i == n - 1) mas[i, j] = 1;
        else if (j + i > n - 1)
        {
            mas[i, j] = 2;

        }
        else mas[i, j] = 0;
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}