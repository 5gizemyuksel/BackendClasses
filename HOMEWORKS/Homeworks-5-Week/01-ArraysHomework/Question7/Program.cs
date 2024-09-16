namespace Question7;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[50];
        int[] arr2 = new int[50];
        int counter = 0;
        int index = 0;
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 101);
        }

        foreach (int item in arr)
        {

            System.Console.WriteLine(item);

        }
        foreach (int item2 in arr)
        {
            if (arr[index] % 2 == 0)
            {
                arr2[counter] = arr[index];
                counter++;
            }
            index++;
        }
        int toplam = 0;
        Array.Resize(ref arr2, counter);
        System.Console.WriteLine("çift sayılar dizisi");
        foreach (int item3 in arr2)
        {
            System.Console.WriteLine(item3);
            toplam += item3;

        }
        System.Console.WriteLine("çif sayıların toplamı: " + toplam);




    }
}
