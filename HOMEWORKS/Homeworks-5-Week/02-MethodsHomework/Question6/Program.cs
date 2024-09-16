namespace Question6;

class Program
{


    static int OddOrEvenNumber(int number)
    {
        if (number % 2 == 0)
        {
            System.Console.WriteLine(number + " Çift sayı");
        }
        else
        {
            System.Console.WriteLine(number + " Tek sayı");
        }

        return number;
    }
    static void Main(string[] args)
    {
        OddOrEvenNumber(8);
    }
}
