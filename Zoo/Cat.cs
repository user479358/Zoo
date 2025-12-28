using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {

    }

    public override string MakeSound()
    {
        return "Мяу!";
    }

    public override string Play()
    {
        if (Energy >= 30)
        {
            Energy -= 30;
            return "Вы поиграли с котом!";
        }
        else
        {
            return "Недостаточно энергии для игры";
        }
    }
}

