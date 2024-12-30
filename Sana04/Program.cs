using Sana04.Classes;
using System.Text;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Виберіть, який конструктор використати для створення об'єкта Airplane:");
Console.WriteLine("1 - Конструктор за замовчуванням");
Console.WriteLine("2 - Конструктор з параметрами");
Console.WriteLine("3 - Конструктор копіювання");
int choice = int.Parse(Console.ReadLine());

Airplane airplane;

switch (choice)
{
    case 1:
        airplane = new Airplane();
        Console.WriteLine("Обраний конструктор за замовчуванням.");
        break;

    case 2:
        Console.WriteLine("Введіть місто відправлення:");
        string startCity = Console.ReadLine();
        Console.WriteLine("Введіть місто прибуття:");
        string finishCity = Console.ReadLine();

        Console.WriteLine("Введіть дату відправлення (рік місяць день година хвилина):");
        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());

        MyDate startDate = new MyDate(year, month, day, hour, minute);

        Console.WriteLine("Введіть дату прибуття (рік місяць день година хвилина):");
        year = int.Parse(Console.ReadLine());
        month = int.Parse(Console.ReadLine());
        day = int.Parse(Console.ReadLine());
        hour = int.Parse(Console.ReadLine());
        minute = int.Parse(Console.ReadLine());

        MyDate finishDate = new MyDate(year, month, day, hour, minute);

        airplane = new Airplane(startCity, finishCity, startDate, finishDate);
        Console.WriteLine("Обраний конструктор з параметрами.");
        break;

    case 3:

        Console.WriteLine("Створіть перший об'єкт Airplane для копіювання.");
        Console.WriteLine("Введіть місто відправлення:");
        startCity = Console.ReadLine();
        Console.WriteLine("Введіть місто прибуття:");
        finishCity = Console.ReadLine();

        Console.WriteLine("Введіть дату відправлення (рік місяць день година хвилина):");
        year = int.Parse(Console.ReadLine());
        month = int.Parse(Console.ReadLine());
        day = int.Parse(Console.ReadLine());
        hour = int.Parse(Console.ReadLine());
        minute = int.Parse(Console.ReadLine());

        startDate = new MyDate(year, month, day, hour, minute);

        Console.WriteLine("Введіть дату прибуття (рік місяць день година хвилина):");
        year = int.Parse(Console.ReadLine());
        month = int.Parse(Console.ReadLine());
        day = int.Parse(Console.ReadLine());
        hour = int.Parse(Console.ReadLine());
        minute = int.Parse(Console.ReadLine());

        finishDate = new MyDate(year, month, day, hour, minute);

        Airplane originalAirplane = new Airplane(startCity, finishCity, startDate, finishDate);

        airplane = new Airplane(originalAirplane);
        Console.WriteLine("Обраний конструктор копіювання.");
        break;

    default:
        {
            Console.WriteLine("Невірний вибір.");
            return;
        }
}

Console.WriteLine($"Місто відправлення: {airplane.GetStartCity()}");
Console.WriteLine($"Місто прибуття: {airplane.GetFinishCity()}");
Console.WriteLine($"Сумарний час подорожі: {airplane.GetTotalTime()} хвилин");
Console.WriteLine($"Чи прибуває в той же день? {airplane.IsArrivingToday()}");