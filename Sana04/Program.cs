using Sana04.Classes;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

bool running = true;

while (running)
{
    Console.WriteLine("Виберіть дію:");
    Console.WriteLine("1 - Створити об'єкт Airplane");
    Console.WriteLine("2 - Створити об'єкт Product");
    Console.WriteLine("3 - Вийти");
    int mainChoice = int.Parse(Console.ReadLine());

    switch (mainChoice)
    {
        case 1:
            Console.WriteLine("Виберіть, який конструктор використати для створення об'єкта Airplane:");
            Console.WriteLine("1 - Конструктор за замовчуванням");
            Console.WriteLine("2 - Конструктор з параметрами");
            Console.WriteLine("3 - Конструктор копіювання");
            int airplaneChoice = int.Parse(Console.ReadLine());

            Airplane airplane;

            switch (airplaneChoice)
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
                    Console.WriteLine("Невірний вибір.");
                    continue;
            }

            Console.WriteLine($"Місто відправлення: {airplane.GetStartCity()}");
            Console.WriteLine($"Місто прибуття: {airplane.GetFinishCity()}");
            Console.WriteLine($"Сумарний час подорожі: {airplane.GetTotalTime()} хвилин");
            Console.WriteLine($"Чи прибуває в той же день? {airplane.IsArrivingToday()}");
            break;

        case 2:
            Console.WriteLine("Виберіть, який конструктор використати для створення об'єкта Product:");
            Console.WriteLine("1 - Конструктор за замовчуванням");
            Console.WriteLine("2 - Конструктор з параметрами");
            Console.WriteLine("3 - Конструктор копіювання");
            int productChoice = int.Parse(Console.ReadLine());

            Product product;

            switch (productChoice)
            {
                case 1:
                    product = new Product();
                    Console.WriteLine("Обраний конструктор за замовчуванням.");
                    break;

                case 2:
                    Console.WriteLine("Введіть назву товару:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введіть ціну товару:");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть валюту товару:");
                    string currencyName = Console.ReadLine();
                    Console.WriteLine("Введіть курс валюти:");
                    double exRate = double.Parse(Console.ReadLine());
                    Currency currency = new Currency(currencyName, exRate);
                    Console.WriteLine("Введіть кількість товару:");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть виробника:");
                    string producer = Console.ReadLine();
                    Console.WriteLine("Введіть вагу товару:");
                    double weight = double.Parse(Console.ReadLine());

                    product = new Product(name, price, currency, quantity, producer, weight);
                    Console.WriteLine("Обраний конструктор з параметрами.");
                    break;

                case 3:
                    Console.WriteLine("Створіть перший об'єкт Product для копіювання.");
                    Console.WriteLine("Введіть назву товару:");
                    name = Console.ReadLine();
                    Console.WriteLine("Введіть ціну товару:");
                    price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть валюту товару:");
                    currencyName = Console.ReadLine();
                    Console.WriteLine("Введіть курс валюти:");
                    exRate = double.Parse(Console.ReadLine());
                    currency = new Currency(currencyName, exRate);
                    Console.WriteLine("Введіть кількість товару:");
                    quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть виробника:");
                    producer = Console.ReadLine();
                    Console.WriteLine("Введіть вагу товару:");
                    weight = double.Parse(Console.ReadLine());

                    Product originalProduct = new Product(name, price, currency, quantity, producer, weight);
                    product = new Product(originalProduct);
                    Console.WriteLine("Обраний конструктор копіювання.");
                    break;

                default:
                    Console.WriteLine("Невірний вибір.");
                    continue;
            }

            Console.WriteLine($"Назва товару: {product.GetName()}");
            Console.WriteLine($"Ціна в гривнях: {product.GetPriceInUAH()}");
            Console.WriteLine($"Загальна вартість у гривнях: {product.GetTotalPriceInUAH()}");
            Console.WriteLine($"Загальна вага товару: {product.GetTotalWeight()} кг");
            break;

        case 3:
            Console.WriteLine("Вихід з програми.");
            running = false;
            break;

        default:
            Console.WriteLine("Невірний вибір.");
            break;
    }
}

