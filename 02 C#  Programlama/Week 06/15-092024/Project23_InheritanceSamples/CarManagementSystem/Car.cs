using System;
using System.ComponentModel;

namespace Project23_InheritanceSamples.CarManagementSystem;

public class Car : Vehicle
{
    public Car(string brand, string model, int year, int countOfDoors) : base(brand, model, year)
    {
        CountOfDoors = countOfDoors;
    }
    public int CountOfDoors { get; set; }


    public void OpenTrunk()
    {
        System.Console.WriteLine("Kaputu var.");
    }

    public override void CarInformation()
    {
        base.CarInformation();
        System.Console.WriteLine($"{CountOfDoors} kapılı");
    }
    public override void GetSignal() //abstract get signali girmek zorundasın ve override olarak giriliyor. 
    {
        throw new NotImplementedException(); //içine bir şey yazmazsan kontrol etmen için. 
    }


}
