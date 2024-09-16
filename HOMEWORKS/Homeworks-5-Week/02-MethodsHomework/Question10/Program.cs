namespace Question10;

class Program
{
    static int ArrayTotal(int[] numbers)
    {
        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        System.Console.WriteLine(total);
        return total;
    }
    static void Main(string[] args)
    {
        int[] array = { 3, 5, 7, 9 };
        ArrayTotal(array);
    }
}
