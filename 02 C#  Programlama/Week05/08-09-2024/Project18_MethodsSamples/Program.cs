namespace Project18_MethodsSamples;

class Program
{

    //kendisine gönderilen int tipindeki sayı listesinde yer alan negatif sayıları geri döndüren bir metot yazınız.

    static List<int> GetNegativeNumbers(List<int> numbers)
    {
        List<int> negativeNumbers = new List<int>();
        foreach (var number in numbers)
        {
            if (number < 0)
            {
                negativeNumbers.Add(number);
            }
        }
        return negativeNumbers;
    }

    static int TotalOFSquares(int number1, int number2)
    {
        int squares1 = number1 * number1;
        int squares2 = number2 * number2;
        int total = squares1 + squares2;
        return total;
    }
    static void Main(string[] args)
    {
        // List<int> numbers=[8,-5,3,-12,4];
        // List<int> resultNumbers= GetNegativeNumbers(numbers);
        // foreach (var number in resultNumbers)
        // {
        //     System.Console.WriteLine(number);
        // }

        //TotalOfSquares(5, 7);//5 ve 7nin karelerini bulup toplayıp geri döndüren metot

        System.Console.WriteLine(TotalOFSquares(3, 4));

            System.Console.WriteLine();

    }
}
