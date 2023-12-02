using System.Globalization;

try
{
    Console.Write("Введите кол-во сотрудников: ");
    int n = int.Parse(Console.ReadLine());
    Employee[] employees = new Employee[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите табельный номер: ");
        employees[i].Id = int.Parse(Console.ReadLine());

        Console.Write("Введите фио сотрудника: ");
        employees[i].Fio = Console.ReadLine();

        Console.Write("Введите дату рождения в формате (ДД-ММ-ГГГГ): ");
        employees[i].Birthday = ParseStringToDateOnly(Console.ReadLine());

        Console.Write("Введите пол (м/ж): ");
        employees[i].Gender = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        
        Console.Write("Введите дату поступления на работу в формате (ДД-ММ-ГГГГ): ");
        employees[i].DateAdmissionJob = ParseStringToDateOnly(Console.ReadLine());
        
        Console.Write("Введите должность сотрудника: ");
        employees[i].Specialization = Console.ReadLine();
        
        Console.Write("Введите оклад: ");
        employees[i].Salary = double.Parse(Console.ReadLine());
    }

    Console.WriteLine();
    
    foreach (var VARIABLE in employees)
    {
        Console.WriteLine($"{VARIABLE.Fio}");
        Console.WriteLine($"{GetAge(VARIABLE.Birthday)} лет");
        Console.WriteLine($"{GetDaysWorked(VARIABLE.DateAdmissionJob)} дней");
        
        if (IsPensioner(VARIABLE) && GetYearsWorked(VARIABLE.DateAdmissionJob) > 30)
        {
            Console.WriteLine("Отработал на предприятии более 30 лет");
        }

        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



DateOnly ParseStringToDateOnly(string date)
{
    try
    {
        if (DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime parsedDate))
        {
            return DateOnly.FromDateTime(parsedDate);
        }
        else
        {
            throw new Exception("Некорректный формат даты.");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

int GetAge(DateOnly birthday)
{
    DateOnly today = DateOnly.FromDateTime(DateTime.Today);
    int age = today.Year - birthday.Year;
    if (birthday > today.AddYears(-age)) age--;
    return age;
}

int GetDaysWorked(DateOnly dateAdmissionJob)
{
    DateTime today = DateTime.Today;
    int daysWorked = (today - new DateTime(dateAdmissionJob.Year, dateAdmissionJob.Month, dateAdmissionJob.Day)).Days;
    return daysWorked;
}

bool IsPensioner(Employee employee)
{
    int pensionAge = (employee.Gender == 'м') ? 60 : 55;

    return GetAge(employee.Birthday) < pensionAge;
}

int GetYearsWorked(DateOnly dateAdmissionJob)
{
    DateTime today = DateTime.Today;
    int yearsWorked = today.Year - dateAdmissionJob.Year;

    if (today.Month < dateAdmissionJob.Month || (today.Month == dateAdmissionJob.Month && today.Day < dateAdmissionJob.Day))
    {
        yearsWorked--;
    }

    return yearsWorked;
}

struct Employee
{
    public int Id;
    public string Fio;
    public DateOnly Birthday;
    public char Gender;
    public DateOnly DateAdmissionJob;
    public string Specialization;
    public double Salary;
}