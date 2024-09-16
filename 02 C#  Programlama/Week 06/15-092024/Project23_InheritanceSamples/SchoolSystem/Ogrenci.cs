using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/*
oğrenci bir kişidir. öğrenicinin ek olarak öğrenci numarası, özelliği vardır. öğrencinin bilgileri ekrana yazdırılırken öğrenci numarası da yazdırılmalıdır. 
*/
public class Ogrenci : Kisi
{

    public int OgrenciId { get; set; }

    public Ogrenci(string ad, string soyad, DateTime dogumTarihi, int ogrenciId) : base(ad, soyad, dogumTarihi)
    {
        OgrenciId = ogrenciId;
    }

    public void OgrenciBilgileri()
    {
        System.Console.WriteLine($"Ad: {Ad} \nSoyad: {Soyad} \nDoğum Tarihi: {DogumTarihi.ToShortDateString()}\nÖğrenci Numarası: {OgrenciId}");
    }
}
