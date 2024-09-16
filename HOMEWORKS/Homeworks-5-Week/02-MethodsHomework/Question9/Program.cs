namespace Question9;

class Program
{

    static int NumberArray(int[] numbers)
    {
        Array.Sort(numbers);
        int number = numbers[0];
        System.Console.WriteLine(number);
        return number;


    }
    static void Main(string[] args)
    {
        int[] array = { 13, 45, 97, 9 };
        NumberArray(array);
    }
}
