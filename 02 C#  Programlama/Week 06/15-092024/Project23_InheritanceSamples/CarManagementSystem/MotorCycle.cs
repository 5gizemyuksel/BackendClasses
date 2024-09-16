using System;

namespace Project23_InheritanceSamples.CarManagementSystem;

public class MotorCycle : Vehicle
{
    public MotorCycle(string brand, string model, int year,bool coolingSystem) : base(brand, model, year)
    {
        CoolingSystem=coolingSystem;
    }
    public bool CoolingSystem { get; set; }

    public override void CarInformation()
    {
        base.CarInformation();
        System.Console.WriteLine($"Soğutma sistemi {CoolingSystem}   ");
    }




}
