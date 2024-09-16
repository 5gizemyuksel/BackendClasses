using System.Data;
using System.Runtime.InteropServices;

namespace Project16_Methods;

class Program
{

    /*
    <Erişim Belirleyici> bir methoda nereden erişebileceğimizi kullnaıp kullanamayacağımızı belirleyecek.
    <Geri dönüş tipi> benim yazdığım method geriye ne tipte veri üretecek onu belirler.
    <MetotAdı(parametre1_tipi parametre_adı, parametre2_tipi parametre2_adı ...)
    {
        metot gövdesi
        işlemleri burada gerçekleştireceğiz
        return geri_döndürülecek_değer;
        return keyWordü sadece metot geriye bir değer döndürecekse kullanılır. 
    }> tüm sözcüklerin ilk harfi büyük geri kalan küçük şekilde yazılır. Emir kipinde isimler olacak. bazen parantez iine parametre eklememiz gerekecek. her zaman geriye bir değer döndürmek zorunda değil. 

        DRY- Don't repeat yourself!

    */

    static void Greet()     //metot oluşturduk.
    {
        System.Console.WriteLine("Merhaba Drogba");
    }

    static string Greet2(string name, bool gender)
    {
        if (gender)
        {
            return $"Merhaba {name} hanım ";
        }
        return $"Mehaba {name} bey";



    }



    static int Sum1() // eğer bir değer döndürecekse return yazmalısın yoksa döndüremiyor diye hata veriyor.
    {
        int a = 40;  // hesapladığı değeri bana geri versin istiyorum yazdırsın istemiyorum onun için return diyorsun cw kullanmıyorsun.
        int b = 50;
        int c = a + b;

        return c;
    }

    //ben sana hangi iki sayıyı verirsem onu topla bana ver için:

    static int Sum2(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }

    static double SumSqrt(double number1, double number2)
    {
        double total = number1 + number2;
        double result = Math.Sqrt(total);
        return result;
    }

    static void SampleNumberValue(ref int originalNumber)
    {
        originalNumber += 3;
        System.Console.WriteLine($"metodun içindeki yazdırma satırı: {originalNumber}"); // eğer daha sonradan bişeyler yazıp onun metodu etkilemesini de istiyorsam ref yazmalıyım.
    }
    static void Bolme(int bolunen, int bolen, out int bolum, out int kalan)
    {
         bolum=bolunen/bolen;
         kalan = bolunen%bolen;
        
    }

    static void Main(string[] args)   //eğer bir metot geriye bir değer döndürmeyecekse void kullanırsın.

    {
        int bolumx;
        int kalany;
        Bolme(8,3, out bolumx, out kalany);
        System.Console.WriteLine($" 8/3 = {bolumx}\n 8/3 işleminden kalan = {kalany}");


        // Greet();  


        // int x = Sum1();    //metotu çağırdık.
        // int y = Sum2(50, 70);
        // int z = Sum2(90, 250);
        // System.Console.WriteLine(x + y + z);

        // double result1 = SumSqrt(4, 12); //4 
        // double result2 = SumSqrt(5, 11);//4
        // double result3 = SumSqrt(2, 23);//5
        // double result4 = SumSqrt(7, 42);//7

        // System.Console.WriteLine(Greet2("Gizem", true));
        // System.Console.WriteLine(Greet2("Mahmut Can", false));

        // int originalNumber = 15;
        // System.Console.WriteLine($"metot çağırmadan önceki orijinalNumber değeri: {originalNumber}");//15

        // SampleNumberValue(ref originalNumber);//18
        // System.Console.WriteLine($"metot çağırıldıktan sonraki originalNumber değeri: {originalNumber}");//15



    }
}
