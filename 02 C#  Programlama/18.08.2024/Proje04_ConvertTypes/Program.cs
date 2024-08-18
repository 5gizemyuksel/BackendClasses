namespace Proje04_ConvertTypes;

class Program
{
    static void Main(string[] args)
    {
        #region Imlicit Convert(örtülü dönüştürme)


        #endregion
        #region Explicit Convert(Açık Dönüştürme)
        // double myValue =123.58;
        // int newMyValue = (int)myValue; // Cast etmek ya da Unboxing 
        // Console.WriteLine("myValue: " + myValue);
        // Console.WriteLine("newMyValue: " + newMyValue);

        //   string numberString ="125";
        //   int result = Convert.ToInt32(numberString) + 75;
        //   Console.WriteLine(result);

        // long numberLong = 75;
        // int numberInt = Convert.ToInt32(numberLong);
        // Console.WriteLine(numberInt );

        // int numberInt = 255;
        // byte numberByte = numberInt; // bu şekşilde olmaz çünkü byte 255ten büyük değer alamaz ama int normalde daha büyük değerler alabildiği için byte'a numberınt yazılmaz

        // int numberInt = 256;
        // byte numberByte = Convert.ToByte(numberInt);
        // Console.WriteLine(numberByte);

        // string age ="43";
        // byte ageByte = byte.Parse(age);
        // Console.WriteLine(ageByte);

        // string number = "125&" ;
        // int numberInt = int.Parse(number);
        // Console.WriteLine(numberInt); // format doğru değil hatası verir çünkü içinde sadece sayı yok.

        // string number = "engin";
        // int numberInt;
        // int.TryParse(number, out numberInt); //string türündeki içindeki number isimli değişkenini int türündeki mumberInt değişkenine yazmayı denemesini sağlar 

        // string number = "engin";
        //  int numberInt; 
        //  bool result = int.TryParse(number, out numberInt);
        //  Console.WriteLine(result); // bool yapabilir mi sorusunu sorar evet ya da hayır gibi cevap alırsın çünkü engin gibi bir değişken inte sayıya çevrilemez false yanıtını alırsın.

        // int numberInt = 256;
        // byte numberByte = (byte)numberInt;
        //  Console.WriteLine(numberByte);  // sonuç hata vermez normalde byte 256 değeri alamaz en yüksek 255 olabilir o yüzden hata vermesi gerekir ama unboxing yönteminde veri kaybına sebep olur o yüzden ikilik sistemden bir sonuç verir 0 ya da 1. convertle yaptığın yöntemden unboxing yöntemi farklı çalışır convert hata verir yapamam der unboxing veri kaybına neden olur. 

        //bazen elindeki herhangi bir değeri stringe dönüştürmen gerekir çünkü c#la dotnet birlikte çalışırken çoğu çözümü string üzerinden vermiştir. 
        // ToString sonuna parantezle kullanılır.


        // int a = 567;
        // string b =a.ToString() ;
        // Console.WriteLine(b);

        // int a = 6;
        // int b =175;
        // // yan yana yazılmaları için 

        // string resultString = a.ToString() + b.ToString(); // sonuç 6175

        // string resultString2 = (a + b).ToString(); //181 çünkü önce değerler toplanır sonra stringe çevrilir. 

        // Console.WriteLine(resultString);
        // Console.WriteLine(resultString2);


















        #endregion
    }
}
