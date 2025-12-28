using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Zoo
{
    public static List<Animal> Animals = new List<Animal>();

    public static void CreateAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public static void FeedAllAnimals()
    {
        foreach (Animal animal in Animals)
        {
            animal.Eat();
        }
    }

    public static string ToSleepAllAnimals()
    {
        foreach (Animal animal in Animals)
        {
            animal.Sleep();
        }
        return "Все животные выспались!";
    }

    public static List<string> PlayWithAllAnimals()
    {
        List<string> list = new List<string>();
        foreach (Animal animal in Animals)
        {
            list.Add(animal.Play());
        }
        return list;
    }

    public static List<string> HearAllAnimals()
    {
        List<string> list = new List<string>();
        foreach (Animal animal in Animals)
        {
            list.Add(animal.MakeSound());
        }
        return list; 
    }

    public static Animal FindAnimal(string name)
    {
        foreach (Animal animal in Animals)
        {
            if (animal.Name == name)
            {
                return animal;
            }
        }
        throw new Exception("Нет животного с таким именем");
    }

    public static void FeedAnimal(Animal animal)
    {
        animal.Eat();
    }
    public static AnimalInfo GetInfoByName(Animal animal)
    {
        return animal.GetInfo();
    }
}

