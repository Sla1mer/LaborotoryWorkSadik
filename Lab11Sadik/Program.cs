// 15 Вариант высокий

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

string[] arrayBin = new string[n];
Random random = new Random();
for (int i = 0; i < arrayBin.Length; i++)
{
    arrayBin[i] = Convert.ToString(random.Next(0, 100), 2);

    Console.Write(arrayBin[i] + " ");
}
Console.WriteLine();

int avarage = 0;

for (int i = 0; i < arrayBin.Length - 1; i++)
{
    int numberDecimal = Convert.ToInt32(arrayBin[i], 10);
    for (int j = i + 1; j < arrayBin.Length; j++)
    {
        if (Convert.ToInt32(arrayBin[i], 10) > Convert.ToInt32(arrayBin[j], 10))
        {
            string temp = arrayBin[i];
            arrayBin[i] = arrayBin[j];
            arrayBin[j] = temp;
        }
    }
    avarage += numberDecimal;
}

foreach (var elem in arrayBin)
{
    Console.Write(elem + " ");
}
Console.WriteLine();
Console.WriteLine($"Avarage={Convert.ToString(avarage / arrayBin.Length, 2)}");