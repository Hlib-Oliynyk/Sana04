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

    string mainChoiceInput = Console.ReadLine();
    if (!int.TryParse(mainChoiceInput, out int mainChoice))
    {
        Console.WriteLine("Некоректний ввід. Спробуйте ще раз.");
        continue;
    }

    switch (mainChoice)
    {
        case 1:
            Console.WriteLine("Виберіть, який конструктор використати для створення об'єкта Airplane:");
            Console.WriteLine("1 - Конструктор за замовчуванням");
            Console.WriteLine("2 - Конструктор з параметрами");
            Console.WriteLine("3 - Конструктор копіювання");

            string airplaneChoiceInput = Console.ReadLine();
            if (!int.TryParse(airplaneChoiceInput, out int airplaneChoice))
            {
                Console.WriteLine("Некоректний ввід. Спробуйте ще раз.");
                continue;
            }

            Airplane airplane;

            if (airplaneChoice == 1)
            {
                airplane = new Airplane();
                Console.WriteLine("Обраний конструктор за замовчуванням.");
            }
            else if (airplaneChoice == 2)
            {
                Console.WriteLine("Введіть місто відправлення:");
                string startCity = Console.ReadLine();

                Console.WriteLine("Введіть місто прибуття:");
                string finishCity = Console.ReadLine();

                Console.WriteLine("Введіть дату відправлення (рік місяць день година хвилина):");
                MyDate startDate = CreateMyDateFromInput();

                Console.WriteLine("Введіть дату прибуття (рік місяць день година хвилина):");
                MyDate finishDate = CreateMyDateFromInput();

                airplane = new Airplane(startCity, finishCity, startDate, finishDate);
                Console.WriteLine("Обраний конструктор з параметрами.");
            }
            else if (airplaneChoice == 3)
            {
                Console.WriteLine("Створіть перший об'єкт Airplane для копіювання.");
                Console.WriteLine("Введіть місто відправлення:");
                string startCity = Console.ReadLine();

                Console.WriteLine("Введіть місто прибуття:");
                string finishCity = Console.ReadLine();

                Console.WriteLine("Введіть дату відправлення (рік місяць день година хвилина):");
                MyDate startDate = CreateMyDateFromInput();

                Console.WriteLine("Введіть дату прибуття (рік місяць день година хвилина):");
                MyDate finishDate = CreateMyDateFromInput();

                Airplane originalAirplane = new Airplane(startCity, finishCity, startDate, finishDate);
                airplane = new Airplane(originalAirplane);
                Console.WriteLine("Обраний конструктор копіювання.");
            }
            else
            {
                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
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

            string productChoiceInput = Console.ReadLine();
            if (!int.TryParse(productChoiceInput, out int productChoice))
            {
                Console.WriteLine("Некоректний ввід. Спробуйте ще раз.");
                continue;
            }

            Product product;

            if (productChoice == 1)
            {
                product = new Product();
                Console.WriteLine("Обраний конструктор за замовчуванням.");
            }
            else if (productChoice == 2)
            {
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
            }
            else if (productChoice == 3)
            {
                Console.WriteLine("Створіть перший об'єкт Product для копіювання.");
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

                Product originalProduct = new Product(name, price, currency, quantity, producer, weight);
                product = new Product(originalProduct);
                Console.WriteLine("Обраний конструктор копіювання.");
            }
            else
            {
                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
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
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            break;
    }
}

MyDate CreateMyDateFromInput()
{
    Console.Write("Рік: ");
    int year = int.Parse(Console.ReadLine());

    Console.Write("Місяць: ");
    int month = int.Parse(Console.ReadLine());

    Console.Write("День: ");
    int day = int.Parse(Console.ReadLine());

    Console.Write("Година: ");
    int hour = int.Parse(Console.ReadLine());

    Console.Write("Хвилина: ");
    int minute = int.Parse(Console.ReadLine());

    return new MyDate(year, month, day, hour, minute);
}

