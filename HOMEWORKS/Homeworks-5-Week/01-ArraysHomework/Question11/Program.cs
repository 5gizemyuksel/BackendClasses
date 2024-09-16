using System.Xml;

namespace Question11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir cümle giriniz:  ");
        string sentences = Console.ReadLine();

        char[] sentencesWord = sentences.ToCharArray();

        int index = sentencesWord.Length - 1;

        System.Console.WriteLine("girilen kelimenin harfler dizisi: ");
        foreach (char word in sentencesWord)
        {
            System.Console.WriteLine(word);
        }
        System.Console.WriteLine("\n");
        System.Console.WriteLine("ters hali\n");
        while (index >= 0)
        {
            System.Console.WriteLine(sentencesWord[index]);
            index--;
        }
    }

}
