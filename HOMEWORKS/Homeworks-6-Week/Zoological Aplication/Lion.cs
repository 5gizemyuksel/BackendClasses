using System;

namespace Zoological_Aplication;

public class Lion : Animal 
{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Species}, {Name} Kükrüyor.");
    }
}
