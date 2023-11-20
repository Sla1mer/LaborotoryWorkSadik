// Высокий уровень
// Вариант 2

Console.Write("Введите первую строку:");
string str1 = Console.ReadLine();

Console.Write("Введите вторую строку:");
string str2 = Console.ReadLine();

string res = "";

for (int i = 0; i < str1.Length; i++)
{
    char currentChar = str1[i];

    if (str2.Contains(currentChar.ToString()) && !res.Contains(currentChar.ToString()))
    {
        res += currentChar;
    }
}

Console.WriteLine($"Результат: {res}");
