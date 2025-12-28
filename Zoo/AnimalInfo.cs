using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct AnimalInfo
{
    public string Name { get; private set; }
    public int Age {get; private set;}
    public int Energy { get; private set; }

    public AnimalInfo(string name, int age, int energy)
    {
        Name = name;
        Age = age;
        Energy = energy;
    }
}
