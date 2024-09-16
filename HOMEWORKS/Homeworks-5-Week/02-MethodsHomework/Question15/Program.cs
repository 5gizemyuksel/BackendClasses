namespace Question15;

class Program
{

    static int ArrayAverage(int[] numbers)
    {
        int total = 0;
        int counter = 0;

        foreach (int number in numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
                counter++;
            }
        }
        int average = total / counter;
        System.Console.WriteLine(average);
        return average;
    }
    static void Main(string[] args)
    {
        int[] array = { 3, 5, 7, 9, 10, 1 };
        ArrayAverage(array);
    }
}
