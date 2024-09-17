using System;

namespace Vehicle_Management_System;

public class Bicycle : Vehicle
{
    public Bicycle(string make, string model, int year, string hasSideCar) : base(make, model, year)
    {
        HasSideCar = hasSideCar;
    }
    public string HasSideCar { get; set; }
    public override void VehicleInformation()
    {
        base.VehicleInformation();
        System.Console.WriteLine($"Yan sepet: {HasSideCar}");
    }
}
