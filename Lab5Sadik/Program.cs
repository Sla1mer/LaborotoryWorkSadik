// Высокий уровень 2

Console.Write("Введите двузначное число: ");
int number = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());

if (number / 10 == 5 || number % 10 == 5)
{
    Console.WriteLine($"Число 5 присутсвует в числе {number}");
}

if (number / 10 == a || number % 10 == a)
{
    Console.WriteLine($"Число {a} присутсвует в числе {number}");
}