namespace Vehicle_Management_System;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("Mercedes", "CLA 180d", 2017);
        vehicle.VehicleInformation();

        System.Console.WriteLine("***********************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Car car = new Car("Mercedes", "CLA 180d", 2017, 4);
        car.VehicleInformation();

        System.Console.WriteLine("***********************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Bicycle bicycle = new Bicycle("Yamaha", "R25", 2016, "Yok");
        bicycle.VehicleInformation();

        System.Console.WriteLine("***********************");
        System.Console.WriteLine();
        System.Console.WriteLine();

    }
}
