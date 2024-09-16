using System.Globalization;
using System.Runtime.InteropServices;

namespace Question16;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int toplam = number;


        int[] arr = new int[0];
        int index = 0;

        Array.Resize(ref arr, arr.Length + 1);
        arr[index] = number;

        do
        {
            System.Console.Write("Lütfen bir sayı giriniz: ");
            number = int.Parse(Console.ReadLine());

            toplam += number;
            index++;

            Array.Resize(ref arr, arr.Length + 1);
            arr[index] = number;



        } while (number != 0);


        System.Console.WriteLine("dizideki sayılar:");
        foreach (int item in arr)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("dizideki sayıların toplamı: " + toplam);
    }
}
