// Вариант 3.28

Console.Write("Введите 4-ёх значное число: ");
int variable = int.Parse(Console.ReadLine());

int reverseVariable = ((variable % 10) * 1000) + ((variable / 10 % 10) * 100) + ((variable / 100 % 10) * 10) + variable / 1000;
Console.WriteLine($"a) Число, полученное при прочтении его цифр справа налево: {reverseVariable}");

int rearrangingB = ((variable / 100 % 10) * 1000) + (variable / 1000 * 100) + ((variable % 10) * 10) + ((variable / 10 % 10));
Console.WriteLine($"б) Число, образуемое при перестановке первой и второй, третьей и четвертой цифр: {rearrangingB}");

int rearrangingV = (variable / 1000 * 1000) + ((variable / 10 % 10) * 100) + ((variable / 100 % 10) * 10) + (variable % 10);
Console.WriteLine($"в) Число, образуемое при перестановке второй и третьей цифр заданного числа: {rearrangingV}");

int rearrangingG1 = ((variable / 10 % 10) * 1000) + ((variable % 10) * 100) + (variable / 1000 * 10) + ((variable / 100 % 10));
Console.WriteLine("г) Число, образуемое при перестановке двух первых и  двух последних цифр заданного числа");
Console.WriteLine($"1 Способ: {rearrangingG1}"); ;
int rearrangingG2 = ((variable % 100) * 100) + (variable / 100);
Console.WriteLine($"2 Способ: {rearrangingG2}"); ;