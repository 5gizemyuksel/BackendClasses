using System;

namespace Zoological_Aplication;

public class Elephant : Animal
{
    public Elephant(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Species}, {Name} boru sesi gibi ses çıkarıyor.");
    }
}
