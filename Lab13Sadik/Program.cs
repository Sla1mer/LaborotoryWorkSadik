// Высокий уровень
// 2 Вариант

char[] mas = new char[7];

for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    mas[i] = char.Parse(Console.ReadLine());
}

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