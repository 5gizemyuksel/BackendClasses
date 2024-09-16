namespace Project20_OOP_Intro;

class FirstClass
{
    // her class bir tiptir. class oluşturarak kendi tiplerimizi oluşturuyoruz.
    // buraya sınıfın özellik ve davranışlarını kodluyor olacağız.
    //özellik dediğimiz şey: property    //bir sınıfta bilgi tutmak için kullandığımız yapı özelliktir.
    // davranış dediğimiz şey : method
    public string message; //özellik
    public string age;  //özellik
    public void DisplayMessage()   //davranış
    {
        System.Console.WriteLine(message);
    }
    // public yazdığın zaman o classın dışında da kullanabilirsin. ama başına private yazdığında ya da bişey yazmadığında sadece o classın içinde kullanılabilir. public ya da private gibi kavramlar erişim belirleyici olarak geçerler.
}



class Program
{
    static void Main(string[] args)
    {
        FirstClass firstClass1=new FirstClass();
        firstClass1.message="selam";
        // System.Console.WriteLine(firstClass1.message);
        firstClass1.DisplayMessage();
        
    }
}
