namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        int[] arr2 = new int[10];
        int counter = 0;


        for (int i = 0; i <= 9; i++)
        {
            System.Console.WriteLine($"{i + 1}. sayı: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("arr dizisi: ");
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write(arr[i]);
        }
        System.Console.WriteLine("\n");

        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                arr2[counter] = arr[i];
                counter++;
            }

        }
        Array.Resize(ref arr2, counter);
        Array.Sort(arr2);
        System.Console.WriteLine("sıralanmış çift sayılar");

        foreach (int item in arr2)
        {
            System.Console.WriteLine(item);
        }




    }
}
