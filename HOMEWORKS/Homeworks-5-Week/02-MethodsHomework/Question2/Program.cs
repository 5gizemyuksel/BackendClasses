namespace Question2;

class Program
{
    static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            System.Console.WriteLine(number1);
        }
        else
        {
            System.Console.WriteLine(number2);
        }
        return number1;
    }

    static void Main(string[] args)
    {
        Compare(19, 15);
    }
}
