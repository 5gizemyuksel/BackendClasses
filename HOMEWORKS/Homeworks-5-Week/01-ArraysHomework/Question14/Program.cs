namespace Question14;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        int toplam = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 3 == 0 && arr[i] != 0)
            {
                System.Console.WriteLine(arr[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    System.Console.WriteLine();
                }
                toplam += arr[i];




            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("3'e bölünebilenlerin toplamı: ");
        System.Console.WriteLine(toplam);

    }
}
