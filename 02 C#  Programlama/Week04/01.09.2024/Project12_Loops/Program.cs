namespace Project12_Loops;

class Program
{
    static void Main(string[] args)
    {
        //kullanıcıdan arka arkaya alınacak sayıları toplayan kodu hazırlayın ancak kullanıcının girdiği sayıların toplamı, 100'den büyük yada eşitse program sona erip toplamı ekrana yazdırın.

        // int total=0;
        // while (total<=100)
        // {
        //     System.Console.Write("Bir sayı giriniz: ");
        //     int inputNumber= int.Parse(Console.ReadLine());
        //     total+= inputNumber;
        // }
        // System.Console.WriteLine(total);



        //sadece sayı girişi yaptıralım!
        // ConsoleKeyInfo character;
        // string resultNumber = "";
        // Console.Write("Bir sayı giriniz: "); // önce bir kere kodun çalışıp sonra döngüye girmesi için aşağıdaki komut do while

        // do
        // {
        //     character = Console.ReadKey(true);
        //     if (char.IsDigit(character.KeyChar))
        //     {
        //         resultNumber += character.KeyChar.ToString();
        //         System.Console.Write(character.KeyChar.ToString());
        //     }

        //     else
        //     {
        //         if (character.Key == ConsoleKey.Backspace && resultNumber.Length > 0)
        //         {
        //             resultNumber = resultNumber.Substring(0, resultNumber.Length - 1);//5874 => 5874 //substring komutunun içine başlangıç ve son indeksinin sayısı girilir ve substring o aralığı kullanır. 
        //             Console.Write("\b \b");// birinci b siler ikinci b sola gider 
        //         }
        //     }
        // } while (character.Key != ConsoleKey.Enter);
        // readkey her basılan karakteri kullanmak için kullanılır ve program sadece en son basılan karakterleri tanır tek karakter olarak alınıp bir bütün yaratılır ama program onu bir bütün kabul etmeyeceği için else kısmının altındaki kodu yazıp silme tuşunu kullanalbilip ve "\b \b" komutuyla silip ve sola doğru ilerlemesinin sağlar bunun sebebi readkey kullanmamız writeline da program yazılan değeri bir bütün olarak alıyordu.


        // girilen sayının asal olup olmadığını kontrol  eden program yazmak.

        // bool isPrime = true;
        // System.Console.Write("bir sayı giriniz: ");
        // int number = int.Parse(Console.ReadLine());
        // if (number <= 1)
        // {
        //     isPrime = false;
        // }
        // else
        // {
        //     for (int i = 2; i <= number - 1; i++)
        //     {
        //         if (number % i == 0)
        //         {
        //             isPrime= false;
        //             break;
        //         }
        //     }
        // }
        // System.Console.WriteLine(isPrime==true? "asal " : "asal değil"); // ==true yazmadan da aynı sonuç alırsın. isprime true'ya eşit değilseyi soracaksan !isPrime kısaltmasıdır. 

        bool isPrime = true;
        System.Console.WriteLine("bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());




        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            do
            {
                int i = 2;
                if (i <= number - 1 && number % i == 0)
                {


                    isPrime = false;

                    break;

                }
                else
                {
                    isPrime = true;
                }

            } while (isPrime == true);

            System.Console.WriteLine(isPrime ? "asal" : "asal değil");


        }







    }
}
