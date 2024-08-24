namespace HomeWork17;

class Program
{
    static void Main(string[] args)
    {
        byte degisken1 = 42;
        short degisken2 = 42;
        int degisken3 = 42;
        long degisken4 = 42;

        int byteAlan = sizeof(int);
        int shortAlan = sizeof(short);
        int intAlan = sizeof(int);
        int longAlan = sizeof(long);

        Console.WriteLine("Byte Tipinin Kapladığı Alan: " + byteAlan);
        Console.WriteLine("Short Tipindeki Değişkenin Kapladığı Alan: " + shortAlan);
        Console.WriteLine("Int Tipindeki Değişkenin Kapladığı Alan: " + intAlan);
        Console.WriteLine("Long Tipindeki Değişkenin Kapladığı Alan: " + longAlan);


    }
}
