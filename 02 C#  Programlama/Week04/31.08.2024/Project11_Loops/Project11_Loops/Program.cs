using System.Diagnostics.Tracing;

namespace Project11_Loops;

class Program
{
    static void Main(string[] args)
    {

        #region for

        // for (int counter = 1; counter <= 5; counter = counter + 1)
        // {
        //         //döngü gövdesi: Döngü içerisinde tekrar tekrar çalıştırılması istediğimiz kodlar
        //         Console.WriteLine($" {counter}.hello world!");
        // i++ => i=i+1;
        //i=i+3; => i+=3;
        // for (int i  = 1; i <= 5; i = i + 1)
        // {

        //     Console.WriteLine($" {i}.hello world!");
        // }
        //ekrana 1 ile 10 arsındaki sayıları yazıdran programı hazırlayınız. 
        /* çrnek çıktı:
        sayı1: 1
        sayı2: 
        ....
        */
        // string message;
        // int counter=1;
        // for (int i = 100; i <= 200; i++)
        // {
        //      message=$"Sayı{counter++}: {i}";
        //      System.Console.WriteLine(message);

        // }
        //1-10 arasındaki çift sayıları ekrana yazdırın.
        //     string message;


        //     for (int i = 1; i <= 10; i++)
        //    {



        //     }
        /* kullanıcıdan iki sayı alın ve bu iki sayı arasındaki çift sayıları yazınız*/

        //     System.Console.WriteLine("alt sınırı giriniz: ");
        //     int min= int.Parse(Console.ReadLine());
        //     min = min % 2 == 0 ? min : ++min;

        //     System.Console.WriteLine("üst sınırı giriniz: ");
        //     int max = int.Parse(Console.ReadLine());

        //     for (int i = min; i <= max ; i+=2)
        //    {
        //         System.Console.WriteLine(i);
        //     }
        // kullanıcının girdiği sayının faktöriyelini hesaplayan programı yazınız. 
        /* 
            5! için
            f=1;
            f=f*2
            f=f*3
            f=f*4
            f=f*5
            */

        // System.Console.Write("Faktöriyeli hesaplanacak sayıyı griniz: ");
        // int value=int.Parse(Console.ReadLine());

        // int factorial=1;
        // for (int i = 2; i <= value; i++)
        // {
        //    // factorial=factorial*i; //aşağıdakinin aynısı
        //    factorial *=i;

        // }
        // System.Console.WriteLine($"{value}!= {factorial}");


        // System.Console.Write("Faktöriyeli hesaplanacak sayıyı griniz: ");
        // int value = int.Parse(Console.ReadLine());

        // int factorial = value;
        // for (int i = value-1 ; i > 1; i--)
        // {
        //     // factorial=factorial*i; //aşağıdakinin aynısı
        //     factorial *= i;

        // }
        // System.Console.WriteLine($"{value}!= {factorial}");
        #endregion
        #region while
        // int i=1;
        // while (i<=5)
        // {
        //     System.Console.WriteLine($" {i}. hello world!");
        //     i++;
        // }

        // int total = 0;
        // string input = "";
        // while (input != "exit")
        // {
        //     System.Console.Write("Toplanıcak sayıyı giriniz(çıkış için exit): ");

        //     input = Console.ReadLine();
        //     if (int.TryParse(input, out int inputNumber))
        //     {
        //         total += inputNumber;
        //     }
        //     else if (input != "exit")
        //     {

        //          System.Console.WriteLine("Geçerli bir değer giriniz!");
        //     }


        // }
        // System.Console.WriteLine($"Toplam: {total}");

        //kullanıcıdan arka arkaya alınacak sayıları toplayan kodu hazırlayın ancak kullanıcının girdiği sayıların toplamı, 100'den büyük yada eşitse program sona erip toplamı ekrana yazdırın.

        int totalLimit = 100;
        int total = 0;

        while (total <= totalLimit)
        {
            System.Console.WriteLine("sayı:");
            int input = int.Parse(Console.ReadLine());
            if (true)
            {
                total += input;
            }

        }
        System.Console.WriteLine(total);






        #endregion



    }
}
