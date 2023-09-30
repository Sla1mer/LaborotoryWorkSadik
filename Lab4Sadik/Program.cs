// Высокий уровень 8

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());

Console.WriteLine((x >= -1 && x <= 1 && y >= 0 && y <= 2) ? "Входит" : "Не входит");