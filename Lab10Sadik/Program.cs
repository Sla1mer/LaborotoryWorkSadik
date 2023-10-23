// Высокий уровень
// Вариант 18

Console.WriteLine("|    f(x)     |");

double x = 0.5;

while(x <= 2)
{
    double fx = 0;

    for(int k = 1; k <= 5; k++)
    {
        int factorial = 1;

        for (int i = 1; i <= k; i++)
        {
            factorial *= i;
        }
        

        fx += (Math.Pow(-1.5, k) * Math.Pow(x, k)) / factorial;
    }

    Console.WriteLine($"|    {fx:F2}    |");

    x += 0.15;
}