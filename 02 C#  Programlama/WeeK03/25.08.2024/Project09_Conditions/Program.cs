using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace Project09_Conditions;

class Program
{
    static void Main(string[] args)
    {
        #region if
        // if (5 > 14)
        // {

        //     System.Console.WriteLine("İşlem tamamlandı.");
        // }
        // else
        // {
        //     System.Console.WriteLine("Hata!");
        // }
        // System.Console.WriteLine("Uygulama sona erdi.");

        // int x = 10;
        // if (x > 15)
        // {
        //     System.Console.WriteLine("Büyüktür");
        // }
        // else if (x < 15)
        // {
        //     System.Console.WriteLine("Küçüktür");
        // }
        // else
        // {
        //     System.Console.WriteLine("Eşittir");
        // }

        //Kullanıcının klavyeden gireceği yaş bilgisini alıp eğer reşit değilse "Reşit değilsiniz, x sene sonra reşit olacaksınız" eğer reşit ise "giriş yapabilirsiniz" yazdıran kodu hazırlayınız.

        // System.Console.Write("Şu anki yaşınızı giriniz: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // int x = 18 - age;

        // if (age < 18)
        // {
        //     System.Console.WriteLine("Reşit değilsiniz, " + x + " sene sonra reşit olacaksınız.");
        // }
        // else if (age > 18)
        // {
        //     System.Console.WriteLine("Giriş yapabilrisiniz.");
        // }
        // else
        // {
        //     System.Console.WriteLine("Giriş yapabilirsiniz.");

        // }

        // DRY - Don't repeat yourself 


        // if (age >= 18)
        // {
        //     System.Console.WriteLine( "Giriş Yapabilrisiniz");
        // }
        // else  
        // {
        //     System.Console.WriteLine("Reşit değilsiniz, " + x + " sene sonra reşit olacaksınız.");
        // }

        // System.Console.Write("Adınızı giriniz: ");
        //  string fullName= Console.ReadLine();
        // System.Console.Write("Şu anki yaşınızı giriniz: ");
        // int age = Convert.ToInt32(Console.ReadLine());



        // if (age >= 18)
        // {
        //     System.Console.WriteLine("Giriş Yapabilrisiniz");
        // }
        // else
        // {
        //     System.Console.WriteLine("Reşit değilsiniz, " + x + " sene sonra reşit olacaksınız.");
        // }

        #endregion
        #region Turnery If 
        // System.Console.WriteLine("Adınızı Giriniz: ");
        // string fullName = Console.ReadLine();

        // System.Console.WriteLine("Yaşınızı Giriniz: ");
        // byte age = byte.Parse(Console.ReadLine());

        // //Ternary If Yapısı //sadece sonucu tanımlamak için kullanıyorsun ? işaretinden sonra farklı farklı kodlar yazamazsın. Bir değişkene aktarmak için kullanılır. Koşulun sonucuna göre tek bir değer kullanacaksan bunu kullanabilirsin.
        // string resultMessage = age >= 18 
        //                              ? $"Giriş yapabilirsin {fullName}" 
        //                              : $"{18 - age} yıl sonra reşit olacaksın, o zaman gel {fullName}";
        // System.Console.WriteLine(resultMessage);

        // System.Console.WriteLine("Notunuzu Giriniz(0-100): ");
        // byte point = byte.Parse(Console.ReadLine());
        // string resultMessage;

        // resultMessage =point>=50
        //                       ? "Geçti!" 
        //                       : "Kaldı!";
        //                       System.Console.WriteLine(resultMessage ); 

        #endregion
        #region Switch 
        // eğer sürekli aynı şeyi kontrol ediyorsan daha düzenli bir kod düzeni oluşturan alternatif bir yöntem.
        //bittiği yere break yazmak zorundasın.
        // byte point = 120;
        // byte resultPoint = 0;
        // switch (point)
        // {
        //     case < 45:
        //         resultPoint = 1;
        //         break;
        //     case < 55:
        //         resultPoint = 2;
        //         break;
        //     case < 70:
        //         resultPoint = 3;
        //         break;
        //     case < 85:
        //         resultPoint = 4;
        //         break;
        //     case <= 100:
        //         resultPoint = 5;
        //         break;

        //     default:
        //         System.Console.WriteLine("Lütfen 0-100 arası bir puan giriniz.");
        //         break;
        // }
        // if (point > 0 && point <= 100)
        // {
        //     System.Console.WriteLine(resultPoint);
        // }
        //ÖDEV: bunun aynısını if ile yapınız. 







        // && ve demek

        #endregion

        //GİRİLEN TARİHİN HAFTA İÇİ Mİ HAFTA SONU MU OLDUĞUNU SÖYLEYEN KODU YAZINIZ. 

        // Console.Write("Bir tarih giriniz(gg.aa.yyyy): ");
        // string inputDate = Console.ReadLine();

        // if (DateTime.TryParse(inputDate, out DateTime date))
        // {
        //     DayOfWeek dayOfWeek = date.DayOfWeek;
        //     System.Console.WriteLine(dayOfWeek);
        //     System.Console.WriteLine(date.ToLongDateString());
        //     switch (dayOfWeek)
        //     {
        //         case DayOfWeek.Saturday:
        //         case DayOfWeek.Sunday:
        //         System.Console.WriteLine("İyi Tatiller!");
        //         break;
        //         default:
        //         System.Console.WriteLine("İyi Çalışmalar!");
        //         break; 

        //     }
        // }
        // else
        // {
        //     System.Console.WriteLine("Hatalı tarih formatı!");
        // }

        //Griilen tarihin hangi mevsime denk geldiğini bulup ekrana ayzdıran kodu switch yapısı kullanarak yazınız. //ÖDEV: 

        System.Console.WriteLine("Bir Tarih Giriniz(gg.aa.yyyy): ");
        string inputDate = Console.ReadLine();

        if (DateTime.TryParse(inputDate, out DateTime date))
        {
            //ÖDEV: 

            switch (date.Month)
            {


                default:
            }

        }








    }
}
