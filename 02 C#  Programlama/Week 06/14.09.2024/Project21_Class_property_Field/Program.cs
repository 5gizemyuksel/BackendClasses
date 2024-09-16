namespace Project21_Class_property_Field;

// class Product
// {
//     int id; // bu fielddır.
//     string name;
//     decimal price;
//     bool isActive;
//         //class içindeki bilgilerin dışarıya kontrollü bir şekilde açılmasını sağlayan yapılara Property diyourz. YAptığımız bu işleme ise KAPSÜLLEME(ENCAPSULATİON)
//     public string Name //bu propertydir.
//     {
//         get
//         {
//             string result = name.Substring(0, 3).ToUpper();
//             // return name.ToUpper(); //her zaman değeri büyük harfle geri vermesi için.
//             return result;
//         }
//         set
//         {
//             name = value;  //value bir propertye dışardan aldığımız değeri koyuyor. 
//         }
//     }

//     public decimal Price
//     {
//         get
//         {
//             return price;
//         }
//         set
//         {
//             if (value < 0)
//             {
//                 price = 0;
//             }
//             else
//             {
//                 price=value;
//             }
//             // price=value<0? 0 :value; //turnery if olarak yazımı
//         }
//     }

// }

class Product
{
    //propfull snippet
    // private int id;
    // public int Id
    // {
    //     get { return id; }
    //     set { id = value; }
    // }

    //aşağıdaki ve yukarıdaki aynıdır. eğer if ya da herhangi başka bir şey tanımlamaycaksak(sadece değeri verip ve çağıracaksak) bu ikisi kullanılabilir.

    public int Id { get; set; } //kodu kalabalıklaştırmamak için. prop snippet.
    // public string? Name { get; set; } //tipin yanına soru işareti koyarsak null olabilme değerini ben biliyorum beni uyarma demek anlamına geliyor.
    public string Name { get; set; } = ""; //burda bir değer belirtiyoruz ama boş belirtiyoruz. aslında içinde bir şey var ama boş. böylece uyarıyı kaldırırsın. 
    public string? Description { get; set; }
    public required string Notes { get; set; } // required dediğinde bir değer girilmesinin zorunlu olduğunu ve null olamayacağını belirtirsin.
    public decimal Price { get; set; }
    public bool IsActive { get; set; }


}

class Student
{
    // aşağıda yazdığımız otomatik olarak oluşur. gözükmez. eğer bir nesne oluşurken çalışmasını istediğimiz kodlar varsa böyle oluşturuyoruz.
    // construvter methodunu diğer methodlardan ayıran özelliklerinden ikisi bulunduğı class ismiyle aynı olmalı ve geri dönüş tipi belirtilmez.
    public Student()
    {
        System.Console.WriteLine($"{DateTime.Now} zamanında yeni bir student oluşturuldu...");
    }
    public Student(int studentNumber) //parantez içine direkt öğrenci numarası girilerek kullanma
    {
        StudentNumber = studentNumber; //kullanıcı eğer isterse öğrenci numarası girerek başlasın.

        System.Console.WriteLine($"{DateTime.Now} zamanında yeni bir student oluşturuldu...");


    }
    public int StudentNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public bool IsActive { get; set; }
}

class Category
{
    public Category(int ıd)
    {
        Id = ıd;
    }

    public Category(int ıd, string name)
    {
        Id = ıd;
        Name = name;
    }

    public Category(int ıd, string name, string description) //eğer bu bilgiler girilmeden bu klas kullanılmasın istiyorsan böyle yazarsın ve boş, otomatik olan constructer methodunu kaldırmış gibi olur. 
    {
        Id = ıd;
        Name = name;
        Description = description;
    }

    public int Id { get; set; }
    public string Name { get; set; }        //bu üç satırı seçip ampule tıklayıp generate constructer diyerek constructer methodu oluşturulur.
    public string Description { get; set; }

}


class Program
{
    static void Main(string[] args)
    {


        Category category1 = new Category(56);
        Category category2 = new Category(65, "Bilgisayar");
        Category category3 = new Category(65, "Bilgisayar", "ve bir çoğu burada");


        // Student s1 = new Student(); //  bir klastan bir nesne oluşturulması esnada çalışmasını istediğimiz kodlar varsa bunu içine yazabileceğimiz kodlar var buna yapıcı kodlar (constructer method) denir. aslında zaten sadece () bunu yaparak bile constructer methodu çağırıyorsun. 

        // Student s2 = new Student(48);
        // System.Console.WriteLine(s2.StudentNumber);


        //     Product product1 = new Product() { Notes = "Bişeyler" };

        //     product1.Id = 5;
        //     // product1.Description = null; // değeri null atarsan, bunu kabul ettiğini belirtirsin. 
        //     product1.Price = 800;
        //     product1.Name = "Macbook Air M2";


        // Product product1 = new Product();
        // product1.Name = "Iphone 14";
        // System.Console.WriteLine(product1.Name);
        // product1.Price = -60000;
        // System.Console.WriteLine(product1.Price);
    }
}
