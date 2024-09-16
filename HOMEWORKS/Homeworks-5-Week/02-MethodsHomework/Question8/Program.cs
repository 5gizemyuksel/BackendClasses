namespace Question8;

class Program
{
    static int Fahrenheit(int celsius)
    {
        int fahrenheit = (((celsius * 9) / 5)) + 32;
        System.Console.WriteLine(celsius + "C = " + fahrenheit + "F'tır.");
        return celsius;
    }
    static void Main(string[] args)
    {
        Fahrenheit(90);
    }
}
