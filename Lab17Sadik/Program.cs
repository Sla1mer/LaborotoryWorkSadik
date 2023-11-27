// Средний уровень
// Вариант 6

try
{
    Console.Write("Введите кол-во поездов: ");
    int n = int.Parse(Console.ReadLine());
    Train[] trains = new Train[n];
    
    for (int i = 0; i < n; i++)
    {
        trains[i] = new Train();
        trains[i].NumberTrain = i + 1;

        Console.Write("Введите направление: ");
        trains[i].Direction = Console.ReadLine();

        Console.Write("Введите расстояние: ");
        trains[i].Distance = int.Parse(Console.ReadLine());
        
        Console.Write("Введите дату и время прибытия (в формате yyyy-MM-dd HH:mm:ss): ");
        string arrival = Console.ReadLine();

        trains[i].TimeArrival = StringToDateTime(arrival);
        
        Console.Write("Введите дату и время отбытия (в формате yyyy-MM-dd HH:mm:ss): ");
        string departures = Console.ReadLine();

        trains[i].TimeDepartures = StringToDateTime(departures);
    }

    foreach (var VARIABLE in trains)
    {
        TimeSpan travelTime = VARIABLE.TimeDepartures - VARIABLE.TimeArrival;
        double averageSpeed = VARIABLE.Distance / travelTime.TotalHours;

        Console.WriteLine($"Средняя скорость: {averageSpeed:F2}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

DateTime StringToDateTime(string datetime)
{
    if (DateTime.TryParse(datetime, out DateTime result))
    {
        return result;
    }
    else
    {
        return DateTime.Now;
    }
}


struct Train
{
    public int NumberTrain;
    public DateTime TimeArrival;
    public DateTime TimeDepartures;
    public string Direction;
    public int Distance;
}

