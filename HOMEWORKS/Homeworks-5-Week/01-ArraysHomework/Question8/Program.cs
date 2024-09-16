namespace Question8;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];

        System.Console.Write("bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 51);
        }
        foreach (int item in arr)
        {
            System.Console.WriteLine(item);
        }

        if (Array.Exists(arr, element => element == number))
        {
            System.Console.WriteLine($"sayı {number} dizide bulunuyor");
        }
        else
        {
            System.Console.WriteLine($"sayı {number} dizide bulunmuyor. ");
            Array.Sort(arr);
            System.Console.WriteLine(number + "'ın diziye eklenmiş hali. ");
            Array.Resize(ref arr, arr.Length + 1);
            arr[10] = number;
            foreach (int item2 in arr)
            {
                Array.Sort(arr);
                System.Console.WriteLine(item2);
            }
        }

    }
}
