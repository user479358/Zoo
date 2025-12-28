class Program
{
    static void Main()
    {
        int choice = 0;
        while (choice != 11)
        {
            Console.WriteLine("1. Добавить собаку\n" +
                "2. Добавить кота\n" +
                "3. Добавить птицу\n" +
                "4. Показать всех животных\n" +
                "5. Покормить всех животных\n" +
                "6. Уложить спать всех животных\n" +
                "7. Поиграть со всеми животными\n" +
                "8. Услышать всех животных\n" +
                "9. Покормить конкретное животное\n" +
                "10. Показать конкретного животного\n" +
                "11. Выход из программы");
            Console.WriteLine("Введите номер действия");
            choice = int.Parse(Console.ReadLine());
            DoChoice(choice);
        }
    }
    private static void DoChoice(int choice)
    {
        string name;
        switch (choice)
        {
            case 1:
                {
                    do
                    {
                        Console.WriteLine("Введите имя собаки: ");
                        name = Console.ReadLine();
                    } while (IsName(name) != true);
                    Console.WriteLine("Введите возраст собаки");
                    int age = int.Parse(Console.ReadLine());
                    Dog dog = new Dog(name, age);
                    Zoo.CreateAnimal(dog);
                    break;
                }
            case 2:
                {
                    do
                    {
                        Console.WriteLine("Введите имя кота: ");
                        name = Console.ReadLine();
                    } while (IsName(name) != true);
                    Console.WriteLine("Введите возраст кота");
                    int age = int.Parse(Console.ReadLine());
                    Cat cat = new Cat(name, age);
                    Zoo.CreateAnimal(cat);
                    break;
                }
            case 3:
                {
                    do
                    {
                        Console.WriteLine("Введите имя птицы: ");
                        name = Console.ReadLine();
                    } while (IsName(name) != true);
                    Console.WriteLine("Введите возраст птицы");
                    int age = int.Parse(Console.ReadLine());
                    Bird bird = new Bird(name, age);
                    Zoo.CreateAnimal(bird);
                    break;
                }
            case 4:
                {
                    ShowAllAnimals();
                    break;
                }
            case 5:
                {
                    Zoo.FeedAllAnimals();
                    Console.WriteLine("Все животные накормлены!");
                    break;
                }
            case 6:
                {
                    Zoo.ToSleepAllAnimals();
                    Console.WriteLine("Все животные уснули!");
                    break;
                }
            case 7:
                {
                    List<string> plays = Zoo.PlayWithAllAnimals();
                    foreach(string play in plays)
                    {
                        Console.WriteLine(play);
                    }
                    break;
                }
            case 8:
                {
                    List<string> plays = Zoo.HearAllAnimals();
                    foreach (string play in plays)
                    {
                        Console.WriteLine(play);
                    }
                    break;
                }
            case 9:
                {
                    Console.WriteLine("Введите имя животного: ");
                    name = Console.ReadLine();
                    Animal animal = Zoo.FindAnimal(name);
                    Zoo.FeedAnimal(animal);
                    Console.WriteLine($"{name} покормлен!");
                    break;
                }
            case 10:
                {
                    Console.WriteLine("Введите имя животного: ");
                    name = Console.ReadLine();
                    Animal animal = Zoo.FindAnimal(name);
                    ShowInfo(animal);
                    break;
                }
            case 11:
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
            default:
                {
                    Console.WriteLine("Ошибка ввода!");
                    break;
                }
        }

    }
    private static void ShowAllAnimals()
    {
        foreach (Animal animal in Zoo.Animals)
        {
            Console.WriteLine($"Имя: {animal.Name}\nВозраст: {animal.Age}\nЭнергия: {animal.Energy}\n");
        }
    }

    private static bool IsName( string name )
    {
        foreach (Animal animal in Zoo.Animals)
        {
            if (animal.Name == name)
            {
                Console.WriteLine("Такое имя уже есть!");
                return false;
            }
        }
        return true;
    }

    private static void ShowInfo(Animal animal)
    {
        AnimalInfo info = Zoo.GetInfoByName(animal);
        Console.WriteLine($"Имя: {info.Name}\nВозраст: {info.Age}\nЭнергия: {info.Energy}\n");
    }
}
