using System.Formats.Asn1;

namespace Project13_GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        string answer;



        int guessNumber;
        int live = 1;
        int liveLimit = 5;
        string resultMessage = "";

        do
        {

            int generatedNumber = rnd.Next(1, 101);
            System.Console.WriteLine($"HİLE=> {generatedNumber}");
            System.Console.WriteLine("******************");
            System.Console.WriteLine();

            do


            {
                System.Console.Write($"{live}. Hak(1-100): ");
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber < generatedNumber)
                {
                    resultMessage = "Daha büyük bir sayı giriniz!";
                }
                else if (guessNumber > generatedNumber)
                {
                    resultMessage = "Daha küçük bir sayı giriniz!";
                }
                if (guessNumber != generatedNumber)
                {
                    live++;

                }
                if (live <= liveLimit && guessNumber != generatedNumber) Console.WriteLine(resultMessage); //tek satır kod olduğu için scope { } kullanmadan yan yana yazabilirsin.


            } while (guessNumber != generatedNumber && live <= liveLimit);
            resultMessage = guessNumber == generatedNumber ? $"kazandın:)\nPuanın: {((liveLimit - live) + 1) * 10} " : "kaybettin";
            System.Console.WriteLine(resultMessage);
            System.Console.WriteLine($"Oynamaya devam etmek istersen E yaz");
            answer = Console.ReadLine();
        } while (answer == "E");

        System.Console.WriteLine("Çıkış İçin Enter!");
    }
}

/*

sayı tahmin oyunu: 
uygulamamızın rastgele üreteceği 1-100 arasındaki bir sayıyı kullanıcının tahmin ederek bulmasını sağlayan bir kod yazacağız
* kullanıcının tahmini üretilen sayıdan küçükse ya da büyükse buna göre yönlendirme yapılsın
* kullanıcıdan 5 tahmin hakkı olsun
* kullanıcı doğru tahmin yaptıysa ya da tahmin hakkı dolduysa uygun mesajı vererek oyun sona ersin.

*/
