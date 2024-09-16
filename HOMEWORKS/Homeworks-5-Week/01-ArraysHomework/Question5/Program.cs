using System.Net.Http.Headers;

namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[100];
        Random rnd = new Random();
        System.Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 20);

        }
        foreach (int item in arr)
        {
            System.Console.WriteLine(item);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {

                System.Console.WriteLine($"{number} sayısı {i} indeksinde tekrar ediyor");
                counter++;

            }
        }


        System.Console.WriteLine($"{number} sayısı dizide {counter} kez tekrar ediyor.");




    }
}
