using System.Text.RegularExpressions;

try
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();
    RemoveExtraSpaces(ref str);
    Console.WriteLine(str);

    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(IsPrime(a));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


void RemoveExtraSpaces(ref string str)
{
    str = Regex.Replace(str, @"\s{2,}", " ");

    int lastDotIndex = str.LastIndexOf(".");
    if (lastDotIndex != -1)
    {
        str = str.Substring(0, lastDotIndex + 1) + str.Substring(lastDotIndex + 1);
    }

    char[] openingPunctuationMarks = { '(', '[', '{' };
    char[] closingPunctuationMarks = { ')', ']', '}' };
    foreach (char openingMark in openingPunctuationMarks)
    {
        foreach (char closingMark in closingPunctuationMarks)
        {
            string pattern = Regex.Escape(openingMark.ToString()) + @"\s+" + Regex.Escape(closingMark.ToString());
            str = Regex.Replace(str, pattern, openingMark.ToString() + closingMark.ToString());
        }
    }
        
    str = str.TrimEnd();
}

bool IsPrime(int a)
{
    if (a < 2) return false;

    for (int i = 2; i < Math.Sqrt(a) + 1; i++)
    {
        if (a % i == 0) return false;
    }

    return true;
}