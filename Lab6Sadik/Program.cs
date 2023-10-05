// Средний уровень 15

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x: ");
double x = double.Parse(Console.ReadLine());

double a, b, c;
switch (n)
{
    case 1:
        {
            a = 3.5;
            b = -0.73;
            c = 2.5;
            double y;

            if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
            {
                y = Math.Sqrt(Math.Abs((a * x) - Math.Pow(Math.Cos(Math.Pow(b, 3) * x), 2) + 5.1 * Math.Pow(c, 2)));   
            } else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Exp(0.04 * x) + Math.Log(Math.Abs(Math.Pow(b, 5) * Math.Cos(x)));
            } else
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log(Math.Abs(b * x - Math.Pow(a, 2)));
            }

            Console.WriteLine($"y = {y}");
        }
        break;
    case 2:
        {
            a = 15.4;
            b = -5.6;
            c = 3.5;
            double y;

            if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
            {
                y = Math.Sqrt(Math.Abs((a * x) - Math.Pow(Math.Cos(Math.Pow(b, 3) * x), 2) + 5.1 * Math.Pow(c, 2)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Exp(0.04 * x) + Math.Log(Math.Abs(Math.Pow(b, 5) * Math.Cos(x)));
            }
            else
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log(Math.Abs(b * x - Math.Pow(a, 2)));
            }

            Console.WriteLine($"y = {y}");
        }
        break;
    case 3:
        {
            a = 5.1;
            b = 4;
            c = 2.7;
            double y;

            if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
            {
                y = Math.Sqrt(Math.Abs((a * x) - Math.Pow(Math.Cos(Math.Pow(b, 3) * x), 2) + 5.1 * Math.Pow(c, 2)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Exp(0.04 * x) + Math.Log(Math.Abs(Math.Pow(b, 5) * Math.Cos(x)));
            }
            else
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log(Math.Abs(b * x - Math.Pow(a, 2)));
            }

            Console.WriteLine($"y = {y}");
        }
        break;
}