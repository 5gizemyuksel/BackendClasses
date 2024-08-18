namespace Proje03_Variables;

class Program
{
    static void Main(string[] args)
    {
        #region değisken isimlendirme kural ve teknikleri
        /* 
        1) C# BÜYÜK / küçük harf duyarlıdır.
        ex: adSoyad ile AdSoyad aynı değildir!

        2) Özel karakterler değişken adı içerisinde yer alamaz.(_) hariç
        ex: Ad Soyad, Ogrenci-Numarası bunlar gecersizdir.
        ex: _AdSoyad, Ad_Soyad geçerlidir.
        ex: Sayi1, Sayi_2, Sayi2Var geçerlidir.
        ex: 1Sayi, 4Not bunlar geçersizdir. Çünkü değişken ismi harf ya da alt tire ile başlamak zorundadır.

        3)Anahtar sözcükler yani C#'ın özel anlam yüklediği sözcükler değişken ismi olarak kullanılamaz 
        ex: int tipinde adı static olan bir değişken adı olamz çünkü static anahtar kelimedir adı void olan bir değişken tanımlayamazsın özel c# sözcüğdür çünkü.
        ex: int static; geçersiz
        ex: stringvoid; geçersi
        ex int @static; geçerli 

        4) Değişkenler anlamlı bir şekilde isimlendirilir.
         ex: string as ; böyle yapmamalı string AdSoyad; daha geçerli
         ex: bool active; değil de bool isActive; daha geçerli
         ex: bool devletOzelTesvikSistemindenYararlanıyorMu ; çok uzun
          bool TesvikVarMı  ; daha doğru

          5) Değişken isimlendirirken camelCase tekniği kullanılmalıdır. 
          tek sözcükse hepsinin küçük harfle yaz birden fazla sözcükse ilk sözcüğü küçük ikinci sözcüğün ilk harfini büyük yazabilirsin
          ex: string anneAdi ; daha geçerli 
          string anneadi ; string anne_adi bunlar camelCase'e uygun değil 
          ex: string mezunOlduğuOkul ; uygun 

          6) Değişken isimlendirirken Türkçe karakter kullanmak yasak değildir. Ancak tercih etmemeniz şiddetle önerilir!

          7) sabit(Const) tanımlarken genellikle tamamen BÜYÜK HARF kullanılır.
          ex: const int MAX_AGE= 40 ; değer yazmak zorundasın çünkü sabit değeri olsun diye const yapısını kullanıyoruz. 
          ex: const double PI=3.14; 



          
       
        */



        #endregion
        #region tam sayılar

        //        //  degiskenAdi=56;
        // //    int degiskenAdi2;
        // //    System.Console.WriteLine(degiskenAdi);
        // // evrensel: Line Comment command+ K C   uncomment Command+ K U 

        //      // tam sayılar);
        //     //c#'ta ayrıca belirtilmedikçe tüm sayısal değerler int tipinde varsayılır.
        //     sbyte studentpoint=78 ;//-128 ile 127 arasındadır 1 byte yer kaplar (8 bit)
        //     System.Console.WriteLine(studentpoint);

        //     byte studentpoint2 = 255; //sıfır ile 255 arasında 1 byte (8 bit)
        //     System.Console.WriteLine(studentpoint2);
        //     short price = 5 ; // 16 bit 
        //     ushort price2 = 65535; //16 bit
        //     int number = -589; // 32 bit
        //     uint number2 = 97; // 32 bit
        //     long longnumber = -98897465; // 64 bit
        //     ulong longnumber2 = 545; //64 bit   
        #endregion
        #region ondalık sayılar
        // float oran = 0.5F; //32 bit, hassasiyet: 7 basamak
        // double oran2 =0.5 ; // 64 bit, hassasiyet: 15-16 basamak
        // decimal maas = 0.5m ; // 128 bit, hassasiyet: 28-29 basamak

        #endregion

        #region diğer tipler 

        //    bool varMi = true ;
        //    bool gecerliMi = false ; //8 bit

        //    char  cevap ='H' ;
        //    char sembol ='&' ; // UTF-16 charset, 16 bit

        #endregion
        #region Value types 
        // yukarıdaki tüm tiplere c^ValueTask types der.
        // value types, bellek

        #endregion
        #region Reference types 
        /* 
        Ram'in stack kısmında verinin yerine, verinin bulunduğu yerin adresini tutan veri */

        #endregion
        // #region temel referans tipleri


        // string adSoyad = "engin niyazi ergül";
        // object nesne = 15;
        // object nesne2 = true;
        // object nesne3 = "merhaba";
        // // string ve object tiplerinin bellekte ne kadar yep kapladığını araştırınız. 


        #endregion
        #region Const(Sabitler)
        const int MAX_AGE = 45;
        int MAX_AGE = 54 

        #endregion






}
}
