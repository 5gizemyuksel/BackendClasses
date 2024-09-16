using System;

namespace Project23_InheritanceSamples.SchoolSystem;

public class Kisi
{
    public Kisi(string ad, string soyad, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }

    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }
    public byte Yas //set yazmayıp sadece get yazmak salt okunur property yapar readonly property.
    {
        get
        {
            return (byte)(DateTime.Now.Year - DogumTarihi.Year);
        }
    }
    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($"Ad: {Ad} \nSoyad: {Soyad} \nDoğum Tarihi: {DogumTarihi.ToShortDateString()}");
    }
}
