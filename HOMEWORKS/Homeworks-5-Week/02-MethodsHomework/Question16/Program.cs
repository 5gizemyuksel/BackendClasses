using System.Runtime.InteropServices.Marshalling;

namespace Question16;

class Program
{
    static bool Palindrom()
    {

        System.Console.Write("Lütfen bir kelime giriniz: ");
        string words = Console.ReadLine();

        char[] palindrom = words.ToCharArray();

        
        for (int i = 0; i < palindrom.Length / 2; i++)
        {
            
                if (palindrom[i] == palindrom[palindrom.Length - i - 1])
                {

                    return true;
                }
                else
                {
                    return false;
                }
            
           
            

        }




        return true;


    }
    static void Main(string[] args)
    {
        if (Palindrom())
        {
            System.Console.WriteLine("palindrom");
        }else
        {
            System.Console.WriteLine("değil");
        }  
    }
}
