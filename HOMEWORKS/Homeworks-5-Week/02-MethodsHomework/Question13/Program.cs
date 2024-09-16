namespace Question13;

class Program
{

    static void FindWord(string sentence)
    {


        string[] splitSentence = sentence.Split(' ', ',', '.', '!');
        int counter = 0;
        foreach (var word in splitSentence)
        {
            char[] words = word.ToCharArray();
            for (int i = 0; i < words.Length; i++)
            {
                counter++;
            }
        }
        System.Console.WriteLine(counter);
    }

    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir metin giriniz: ");
        string sentence = Console.ReadLine();
        FindWord(sentence);
    }
}
