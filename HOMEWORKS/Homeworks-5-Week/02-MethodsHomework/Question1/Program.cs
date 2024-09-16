namespace Question1;

class Program
{


    // static void Age()
    // {
    //     System.Console.Write("Lütfen yaşınızı giriniz: ");
    //     int age = int.Parse(Console.ReadLine());

    //     if (age > 65)
    //     {
    //         System.Console.WriteLine("emeklilik yaşında");
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("çalışma yaşında");
    //     }

    // }

    static int Age(int age)
    {
        if (age >= 65)
        {
            System.Console.WriteLine("Emeklilik yaşında");
        }
        else
        {
            System.Console.WriteLine("Çalışma yaşında");
        }
        return age;
    }
    static void Main(string[] args)
    {
        // Age();
        Age(20);
    }
}
