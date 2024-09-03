namespace Project10_ErrorHandling;

class Program
{
    static void Main(string[] args)
    {
        #region Try Catch Syntax

        try
        {

        }
        catch (System.Exception)
        {

            throw;
        }

        #endregion
        #region Try catch
        // Console.Clear();
        // System.Console.WriteLine("1. sayı: ");
        // int number1= int.Parse(Console.ReadLine());

        // System.Console.WriteLine("2. sayı: ");
        // int number2 = int.Parse(Console.ReadLine());

        // int result= number1/number2;
        // Console.WriteLine(result);

        #endregion
        #region Name
        // int number1 = default;
        // int number2 = default;
        // string result = default;//başlangıç değerinde hata vermesin diye default yazıyoruz
        // try
        // {

        //     System.Console.Write("1. sayı: ");
        //     number1 = int.Parse(Console.ReadLine());

        //     System.Console.Write("2. sayı: ");
        //     number2 = int.Parse(Console.ReadLine());

        //     result = (number1 / number2).ToString(); //her koşulda hata olsa da olmasa da resultı yazdırmak istersen int resultı stringe çevirirsin 
        //     Console.WriteLine(result);
        // }
        // catch (FormatException error) //error exceptiona isim olarak yazılır
        // //format exception tanımladığın için sadece format hatasında çalışır
        // {
        //     result = "Lütfen geçerli bir değer giriniz!"; //error.Message yazınca hatanın mesajına erişirsin. 

        // }
        // catch (OverflowException)
        // {
        //     result = $"Lütfen {int.MinValue}-{int.MaxValue} arasında bir değer giriniz.";
        // }
        // catch (DivideByZeroException)
        // {
        //     result =  $"0 girdiğiniz için default olarak 1'e bölme işlemi yapıldı. \n{number1.ToString()}";

        // }

        // catch (Exception ex)//format exception dışındaki hataları tutar.
        // {
        //     result = ex.Message;
        // }
        // finally
        // {
        //    System.Console.WriteLine(result);
        // }

        // System.Console.WriteLine("Program sona erdi...");
        #endregion
    }
}
