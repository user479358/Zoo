using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {

    }

    public override string MakeSound()
    {
        return "Гав-гав!";
    }

    public override string Play()
    {
        if (Energy >= 30)
        {
            Energy -= 30;
            return "Вы поиграли с собакой!";
        }
        else
        {
            return "Недостаточно энергии для игры";
        }
    }
}

