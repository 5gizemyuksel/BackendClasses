namespace Question13;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
        int tekToplam = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                tekToplam += arr[i];


            }

        }
        System.Console.WriteLine("toplam: " + tekToplam);

        if (tekToplam % 2 != 0)
        {
            System.Console.WriteLine("toplam tek sayı");
        }
        else
        {
            System.Console.WriteLine("toplam çift sayı");
        }

    }
}
