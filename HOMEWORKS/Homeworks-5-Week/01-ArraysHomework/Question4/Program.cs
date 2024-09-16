namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        // int[] arr = new int[100];
        // Random rnd = new Random();

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     arr[i] = rnd.Next(-100, 100);

        // }
        // foreach (int item in arr)
        // {
        //     System.Console.WriteLine(item);
        // }
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     for (int j = i + 1; j < arr.Length; j++)
        //     {
        //         if (arr[i] == arr[j])
        //         {
        //             System.Console.WriteLine($"{i} indeksindeki {arr[i]} değeri {j} indeksinde tekrar ediyor.");
        //         }
        //     }
        // }

        int[] arr = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-100, 100);
        }





    }
}
