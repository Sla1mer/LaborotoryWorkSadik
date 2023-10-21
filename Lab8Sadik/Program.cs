// Вариант - 17

Console.Write("Введите A: ");
double monthlyScholarship = double.Parse(Console.ReadLine()); 

Console.Write("Введите B: ");
double monthlyExpenses = double.Parse(Console.ReadLine()); 

double totalMoneyNeeded = 0; 

for (int i = 1; i <= 10; i++)
{
    totalMoneyNeeded += monthlyExpenses;
    monthlyExpenses *= 1.03;
}

if (totalMoneyNeeded <= monthlyScholarship * 10)
{
    Console.WriteLine("Вы сможете прожить учебный год без дополнительных средств.");
}
else
{
    Console.WriteLine($"Вам понадобится дополнительно {totalMoneyNeeded - monthlyScholarship * 10:F2} гривен.");
}