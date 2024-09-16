using System.Security.Cryptography;

namespace Question5;

class Program
{
    static void Uppercase(string[] array)
    {
        foreach (string word in array)
        {
            string upperCase = word.ToUpper();
            System.Console.WriteLine(upperCase);

        }

    }
    static void Main(string[] args)
    {
        string[] nameArray = { "gizem" };

        Uppercase(nameArray);
    }
}
