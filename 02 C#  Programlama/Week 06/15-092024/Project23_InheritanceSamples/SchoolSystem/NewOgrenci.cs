using System;

namespace Project23_InheritanceSamples.SchoolSystem;

public class NewOgrenci : Kisi
{
    public NewOgrenci(string ad, string soyad, DateTime dogumTarihi, int ogrenciNo) : base(ad, soyad, dogumTarihi)
    {
        OgrenciNo=ogrenciNo;
    }
    public int OgrenciNo{ get; set; }

    public override void BilgileriEkranaYaz()
    {
        // System.Console.WriteLine($"Ad: {Ad} \nSoyad: {Soyad} \nDoğum Tarihi: {DogumTarihi.ToShortDateString()}\nÖğrenci Numarası: {OgrenciNo}");
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"ÖğrenciNumarası: {OgrenciNo}");
    }
}
