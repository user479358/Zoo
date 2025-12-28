using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bird : Animal
{
    public Bird(string name, int age) : base(name, age)
    {

    }

    public override string MakeSound()
    {
        return "Чик-чирик!";
    }

    public override string Play()
    {
        if (Energy >= 30)
        {
            Energy -= 30;
            return "Вы поиграли с птицей!";
        }
        else
        {
            return "Недостаточно энергии для игры";
        }
    }
}

