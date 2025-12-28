using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{ 
    public string Name {get; private set;}
    public int Age {get; private set;}
    public int Energy {get; protected set;}

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
        Energy = 0;
    }

    public void Eat()
    {
        if (Energy <= 80)
        {
            Energy += 20;
        }
        else
        {
            Energy = 100;
        }
    }

    public void Sleep()
    {
        Energy = 100;
    }

    public virtual string MakeSound()
    {
        return "";
    }

    public virtual string Play()
    {
        if (Energy >= 30)
        {
            Energy -= 30;
            return "";
        }
        else
        {
            return "Недостаточно энергии для игры";
        }
    }

    public AnimalInfo GetInfo()
    {
        AnimalInfo info = new AnimalInfo(Name, Age, Energy);
        return info;
    }
}

