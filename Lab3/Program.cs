using System;

class Dog
{
    // Поля класу
    public string Name { get; set; }       // Ім'я собаки
    public string Color { get; set; }      // Колір собаки
    public double Weight { get; set; }     // Вага собаки (в кг)
    public bool IsSleeping { get; private set; } // Стан сну (спить чи не спить)

    // Конструктор 1: для ініціалізації з ім'ям, кольором та вагою
    public Dog(string name, string color, double weight)
    {
        Name = name;
        Color = color;
        Weight = weight;
        IsSleeping = false; // За замовчуванням собака не спить
    }

    // Конструктор 2: для ініціалізації тільки з ім'ям (використовує стандартні значення для інших властивостей)
    public Dog(string name)
    {
        Name = name;
        Color = "невідомий"; // За замовчуванням колір невідомий
        Weight = 10; // За замовчуванням вага 10 кг
        IsSleeping = false; // За замовчуванням собака не спить
    }

    // Конструктор 3: для ініціалізації з ім'ям і кольором (використовує стандартне значення для ваги)
    public Dog(string name, string color)
    {
        Name = name;
        Color = color;
        Weight = 10; // За замовчуванням вага 10 кг
        IsSleeping = false; // За замовчуванням собака не спить
    }

    // Метод для зміни ваги собаки
    public void ChangeWeight(double newWeight)
    {
        if (newWeight <= 0)
        {
            Console.WriteLine("Вага не може бути меншою або рівною нулю.");
        }
        else
        {
            Weight = newWeight;
            Console.WriteLine($"{Name} змінив свою вагу на {Weight} кг.");
        }
    }

    // Метод для зміни кольору собаки
    public void ChangeColor(string newColor)
    {
        Color = newColor;
        Console.WriteLine($"{Name} змінив свій колір на {Color}.");
    }

    // Метод для бігу собаки
    public void Run()
    {
        if (IsSleeping)
        {
            Console.WriteLine($"{Name} спить і не може бігати.");
        }
        else
        {
            if (Weight > 20)
            {
                Console.WriteLine($"{Name} бігає повільно, оскільки він великий.");
            }
            else
            {
                Console.WriteLine($"{Name} бігає швидко, оскільки він маленький.");
            }
        }
    }

    // Метод для гавкання собаки
    public void Bark()
    {
        if (IsSleeping)
        {
            Console.WriteLine($"{Name} спить і не може гавкати.");
        }
        else
        {
            if (Weight > 20)
            {
                Console.WriteLine($"{Name} гавкає голосно, бо він великий.");
            }
            else
            {
                Console.WriteLine($"{Name} гавкає тихо, бо він маленький.");
            }
        }
    }

    // Метод для того, щоб собака заснув
    public void Sleep()
    {
        if (IsSleeping)
        {
            Console.WriteLine($"{Name} вже спить.");
        }
        else
        {
            IsSleeping = true;
            Console.WriteLine($"{Name} заснув.");
        }
    }

    // Метод для того, щоб собака прокинувся
    public void WakeUp()
    {
        if (!IsSleeping)
        {
            Console.WriteLine($"{Name} вже прокинувся.");
        }
        else
        {
            IsSleeping = false;
            Console.WriteLine($"{Name} прокинувся.");
        }
    }

    // Метод для надання опису собаки
    public void Describe()
    {
        Console.WriteLine($"{Name} — це {Color} собака вагою {Weight} кг.");
        Console.WriteLine(IsSleeping ? $"{Name} зараз спить." : $"{Name} зараз прокинувся.");
    }

    // Статичний метод для порівняння двох собак за вагою
    public static void CompareWeight(Dog dog1, Dog dog2)
    {
        if (dog1.Weight > dog2.Weight)
        {
            Console.WriteLine($"{dog1.Name} важчий за {dog2.Name}.");
        }
        else if (dog1.Weight < dog2.Weight)
        {
            Console.WriteLine($"{dog2.Name} важчий за {dog1.Name}.");
        }
        else
        {
            Console.WriteLine($"{dog1.Name} і {dog2.Name} мають однакову вагу.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення екземплярів класу Dog різними конструкторами
        Dog bigDog = new Dog("Барон", "рудий", 25);
        Dog smallDog = new Dog("Рекс", "чорний", 15);
        Dog unnamedDog = new Dog("Шерлок"); // Використовує стандартні значення для кольору і ваги
        Dog colorNamedDog = new Dog("Петя", "білий"); // Використовує стандартне значення для ваги

        // Опис собак
        bigDog.Describe();
        smallDog.Describe();
        unnamedDog.Describe();
        colorNamedDog.Describe();

        // Демонстрація роботи програм
        bigDog.Run();   // Повільно бігає
        bigDog.Bark();  // Голосно гавкає

        smallDog.Run(); // Швидко бігає
        smallDog.Bark();// Тихо гавкає

        // Собака засинає
        bigDog.Sleep();
        smallDog.Sleep();

        // Після того, як собаки заснуть, вони не зможуть бігати і гавкати
        bigDog.Run();   // Не може бігати, бо спить
        bigDog.Bark();  // Не може гавкати, бо спить

        smallDog.Run(); // Не може бігати, бо спить
        smallDog.Bark();// Не може гавкати, бо спить

        // Пробудження собак
        bigDog.WakeUp();
        smallDog.WakeUp();

        bigDog.Run();   // Повільно бігає
        bigDog.Bark();  // Голосно гавкає

        smallDog.Run(); // Швидко бігає
        smallDog.Bark();// Тихо гавкає

        // Зміна ваги та кольору собаки
        bigDog.ChangeWeight(30);
        smallDog.ChangeColor("білий");

        // Порівняння двох собак
        Dog.CompareWeight(bigDog, smallDog);
    }
}
