using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/*
öğretmen bir kişidir.
öğretmenin ek olarak branş ve maaş biigisi olacak.
Maaş bilgisinin Negatif değer olarak girilmesine izin verilmeyecek.(sadece hata mesajı verilmesi yeter)
Öğretmenin bilgileri ekrana yazdırılırken brabnş ve maaş bilgisi de yazdırılacak.

*/
public class Ogretmen : Kisi
{

    public Ogretmen(string ad, string soyad, DateTime dogumTarihi, string brans, decimal maas) : base(ad, soyad, dogumTarihi)
    {
        Brans = brans;
        Maas = maas;

    }
    public string Brans { get; set; }
    decimal maas;
    public decimal Maas
    {


        get { return maas; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Negatif bir maaş girişi yapılamaz!");

            }
            maas = value;
        }

    }

    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Öğretmenin Branşı: {Brans}\nÖğretmenin Maaşı: {Maas:C2}");
    }


}
