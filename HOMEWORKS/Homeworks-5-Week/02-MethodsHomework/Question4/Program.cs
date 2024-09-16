namespace Question4;

class Program
{
    static double Point(double vizePoint, double finalPoint)
    {
        double vize40 = vizePoint * 0.40;
        double final60 = finalPoint * 0.60;

        double resultPoint = (vize40 + final60);

        System.Console.WriteLine(resultPoint);
        if (resultPoint < 50)
        {
            System.Console.WriteLine("Kaldı!");
        }
        else
        {
            System.Console.WriteLine("Geçti!");
        }
        return vizePoint;
    }
    static void Main(string[] args)
    {
        Point(77, 80);
    }
}
