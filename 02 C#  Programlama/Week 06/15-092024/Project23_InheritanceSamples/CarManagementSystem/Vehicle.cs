using System;
using System.ComponentModel;

namespace Project23_InheritanceSamples.CarManagementSystem;

public abstract class Vehicle //abstract yazınca bir classın başına kendisinden bir nesne yaratılamayan bir soyut class anlamına gelşiyor tek anlamı başka sınıflara miras vermek oluyor böyle olunca. eğer her metodu miras aldığı classın içinde tekrar yazdırmayı zorunlu kılacaksak abstract classın içinde abstract bir metod yazarız. Eğer class Car'sa Cara gçöre tırsa tıra göre metod yazılmasını zorunlu kılmak için.
{
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public string Brand { get; set; }
    public string Model { get; set; }

    public int Year { get; set; }

    public void Start()
    {
        System.Console.WriteLine("Araç çalıştı!");
    }
    public void Stop()
    {
        System.Console.WriteLine("Araç Durdu!");
    }

    public virtual void CarInformation()
    {
        System.Console.WriteLine($"{Brand} Marka \n{Model} Model\n{Year} Çıkış Yılı");
    }
    public abstract void GetSignal();
    


}

