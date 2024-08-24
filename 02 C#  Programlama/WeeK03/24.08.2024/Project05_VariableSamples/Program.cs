using System.Net.Http.Headers;

namespace Project05_VariableSamples;

class Program
{
    static void Main(string[] args)
    {
        #region Yaş Hesaplama
        // //Kullanıcıdan doğum yılını alıp yaşını hesaplayacak ve bunu ekrana yazdıracak kodu hazırlıyoruz.
        // Console.Write("Doğum yılınızı giriniz: ");
        // string input = Console.ReadLine(); // "1975" inputun içinde öyle gözükücek sayısal bir değer olarak gözükmeyecek.
        // int birthYear = int.Parse(input); // burda sayısal bir değer kazandı dönüştü
        // int calculatedAge = DateTime.Now.Year - birthYear; // Date.Time tarihi verir Now şu anı salisesine kadar yearda bunun içinden seneyi
        // string message= "Yaşınız: "+ calculatedAge ;
        // Console.WriteLine(message);




        #endregion
        #region Ürün Fiyat Hesaplama
        //Bir ürünün fiyatı girirldiğinde, onun KDV dahil fiyatını hesaplayıp hem ham hem de KDV dahil fiyatını ekrana yazdıracağız.

        // Console.Write("Ürün fiyatını giriniz: ");
        // decimal productPrice = decimal.Parse(Console.ReadLine());
        // double vatRate = 0.18;
        // double vat = (double)productPrice * vatRate;
        // decimal totalProductPrice = productPrice + (decimal)vat;

        // string resultMessage = $@"
        // Ürün Fiyatı    : {productPrice}
        // KDV            : {vat}
        // // KDV Dahil Fiyat:{totalProductPrice}";
        // // Console.WriteLine(resultMessage); // tek bir stringte alt alta sonuç yazdırmak için

        // string resultMessage =$"Ürün Fiyatını giriniz:"{productPrice} //EKSİK KALDI
        #endregion

        #region Sıcaklık Dönüştürme 
        // Kullanıcıdan Celsius cinsinden alınan sıcaklık değerini, Fahrenheit cinsine çevirip ekrana her ikisini de alt alta yazdıran kodu hazırlıyoruz. 

        // Console.Write("Celcius Değerini Giriniz: ");
        // decimal Celsiusdeger= decimal.Parse(Console.ReadLine());
        // double fahrenheit = ((double)Celsiusdeger*9/5)+32;


        // string resultMessage = $@"
        // Celsius Değeri: {Celsiusdeger}
        // Fahrenheit Değeri: {fahrenheit}";

        // System.Console.WriteLine(resultMessage); //benim yazdığım

        // System.Console.Write("Celsius sıcaklık değerini giriniz: ");
        // double celsius= double.Parse(Console.ReadLine());

        // double fahrenheit = (celsius * 1.8) + 32;
        // string resultMessage = $"Celsius: {Convert.ToInt32(celsius)}\nFahrenheit: {Convert.ToInt32(fahrenheit)}";
        // Console.Clear();
        // Console.WriteLine("Sonuç:");
        // System.Console.WriteLine("----");
        // System.Console.WriteLine(resultMessage); // $ işaretini düzenli yazmak için kullanıyoruz.








        #endregion
        #region Ağırlık Dönüştürme 
        // Kullanıcının girdiği kg cinsinden ağırlığı gram'a çevirip sonucu ekrana yazıdıran kodu hazırlayınız.
        //Not: küsüratlı değerler girilebilri
        // not: sonuç ekranında hem kg hem gr değerlerini düzgünce göstermeliiniz.

        // System.Console.Write("Kilogram değerini giriniz: ");
        // double kgDegeri = double.Parse(Console.ReadLine());

        // double grDegeri = kgDegeri * 1000 ;


        // string resultMessage= $@"
        // Sonuç
        // -----
        // Kilogram: {kgDegeri} 
        // Gram: {grDegeri}
        // ";
        // System.Console.WriteLine(resultMessage);

        #endregion











    }
}
