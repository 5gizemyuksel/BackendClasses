namespace Project17_methodoverloading;

class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }
    //aynı isme sahip metodları nasıl kullanabiliriz overload yapıyoruz


    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }



    static int Sum(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }


    // sum için üç farklı çalışma koşulu yaptık

    // static void Greet(string name, byte age)  // bu satır method imzası diye geçer 
    // {
    //    System.Console.WriteLine($"Merhaba {age} yaşındaki {name}");
    // }



    // static void Greet(byte age, string name )
    // {
    //     System.Console.WriteLine($"Merhaba {age} yaşındaki {name}");
    // }

    static string GetCoffe(string coffeType, int quantitySugar = 0, bool withMilk = true) // varsayılan değer verdik ve eğer yazdırırken parametre içinde değer belirtmezsek şekeri 0 kabul eder şekerszi yazar sütlüyü true kabul eder sütlü yazar. Varsayılan değer atayacaksan paarmetre içine varsayılan değer verdiğin parametreyi en sona yazmak zorundasın.
    {
        string coffee = $"{coffeType} kahve";
        coffee += quantitySugar > 0 ? $" , {quantitySugar} şekerli " : ", şekersiz";
        if (withMilk)
        {
            coffee += ", sütlü. ";

        }
        else
        {
            coffee += ", sütsüz. ";
        }
        coffee += "Kahveniz hazır afiyet olsun";
        return coffee;
    }
    static void Main(string[] args)
    {

        System.Console.WriteLine(GetCoffe("Americano", 2, false));





        // System.Console.WriteLine(Sum(18, 5));

    }
}
