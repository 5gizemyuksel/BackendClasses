﻿namespace Project22_Inheritance;

class Bird
{
    public void Fly()
    {
        System.Console.WriteLine("Kuş uçuyor!");
    }
}


class Penguin : Bird  //penguen classı bird classında ne varsa miras aldı. //penguen aynı zamanda bir birdtür. //birdde ne varsa bütün özellikleri penguine devretti ve miras aldı penguin. Bird Base classtır. // miras veren class her classa miras verebilir ama class alan sınıf sadece bir sınıftan miras alabilir. 
{

    public void Swim()
    {
        System.Console.WriteLine("Penguen yüzüyor!");
    }

}


class Otomobil
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int ModelYili { get; set; }
}

class IctenYanmalıOtomobil : Otomobil
{
    public string YakitTipi { get; set; }
    public string MotorGucu { get; set; }
}

class ElektrikliOtomobil : Otomobil
{
    public string Menzil { get; set; }
    public bool KendiniSarjEtme { get; set; }
}




class Program
{
    static void Main(string[] args)
    {

        ElektrikliOtomobil elektrikliOtomobil=new ElektrikliOtomobil();
        
        // Penguin penguin1 = new Penguin();
        // penguin1.Swim();
        // penguin1.Fly();



    }
}
