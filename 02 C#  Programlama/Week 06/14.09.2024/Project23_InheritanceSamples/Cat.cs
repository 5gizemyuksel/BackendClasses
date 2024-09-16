using System;

namespace Project23_InheritanceSamples;

public class Cat:Animal
{
    public Cat(string name, int age, string color):base(name,age) //animalde zorunlu parametre olduğu için miras alabilmek için parametre belirlemek zorunlu ve sonrasında aldığımız parametreyi animale göndericez. base ile.
    {
        Color=Color;
    }
    public string Color { get; set; }
}
