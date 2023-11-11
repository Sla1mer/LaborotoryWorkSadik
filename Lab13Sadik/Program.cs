// Высокий уровень
// 2 Вариант

char[] mas = new char[7];
Console.Write("Введите строку: ");
mas = Console.ReadLine().ToLower().ToCharArray();

bool isSymmetrical = true;
for (int i = 0; i < mas.Length / 2; i++)
{

    if (mas[i] != mas[mas.Length - i - 1])
    {
        isSymmetrical = false;
        break;
    }
}

if (isSymmetrical)
{
    Console.WriteLine("Симметричный");
} else
{
    Console.WriteLine("Не симметричный");
}