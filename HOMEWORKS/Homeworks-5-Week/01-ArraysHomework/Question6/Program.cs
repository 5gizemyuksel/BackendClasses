namespace Question6;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[100];
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-100, 101);
        }
        System.Console.WriteLine("dizi elemanları: ");
        foreach (int item in arr)
        {
            System.Console.WriteLine(item);
        }

        Array.Sort(arr);
        System.Console.WriteLine($"en küçük sayı: {arr[0]}\nEn büyük sayı: {arr[99]}");

    }
}
