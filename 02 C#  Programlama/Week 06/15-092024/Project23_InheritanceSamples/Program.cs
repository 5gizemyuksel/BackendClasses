using Project23_InheritanceSamples.CarManagementSystem;
using Project23_InheritanceSamples.SchoolSystem;    // proje23ün içindeki başka bir klasörün içindekileri kullanmak için using ile hangi dosya olduğunu belirtmeliyiz.
namespace Project23_InheritanceSamples;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vhc1=new Vehicle("Mercedes","CLA",2017);
        vhc1.CarInformation();

        System.Console.WriteLine("******************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Car car1=new Car("Mercedes","CLA", 2017,4);
        car1.CarInformation();
        car1.OpenTrunk();

        System.Console.WriteLine("******************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        MotorCycle mc1=new MotorCycle("Mercedes","CLA",2017,true);
        mc1.CarInformation();


        // Ogretmen ogretmen1 = new Ogretmen("Mustafa Kemal", "Atatürk", new DateTime(1881, 5, 19), "Geometri", 40000);
        // ogretmen1.BilgileriEkranaYaz();

        // NewOgrenci newOgrenci1= new NewOgrenci();

        // Kisi kisi1= new Kisi("Ceren","Turna", new DateTime(1990,6,14));
        // kisi1.BilgileriEkranaYaz();
        // System.Console.WriteLine($"Kişinin yaşı: {kisi1.Yas}");

        // Ogrenci ogrenci1= new Ogrenci("Gizem", "Yüksel", new DateTime(2002,4,17), 731);
        // ogrenci1.OgrenciBilgileri();
        // System.Console.WriteLine($"Öğrencinin yaşı: {ogrenci1.Yas}");



        // Cat cat1= new Cat("Heda", 5, "Siyah");
        // cat1.MakeSound();

        // Dog dog1= new Dog("Ares",3,4,"3 yavrusu var");
        // dog1.MakeSound();
        // dog1.Swim();
    }
}
