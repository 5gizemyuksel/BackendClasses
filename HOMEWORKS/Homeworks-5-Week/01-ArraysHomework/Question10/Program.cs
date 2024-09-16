namespace Question10;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] arr2 = new int[10];
        Array.Copy(arr1, arr2, arr1.Length);
        Array.Reverse(arr2);

        System.Console.WriteLine("Dizinin ilk hali: ");
        foreach (int item1 in arr1)
        {
            System.Console.WriteLine(item1);
        }

        System.Console.WriteLine("Dizinin ters hali: ");
        foreach (int item2 in arr2)
        {
            System.Console.WriteLine(item2);
        }



    }
}
