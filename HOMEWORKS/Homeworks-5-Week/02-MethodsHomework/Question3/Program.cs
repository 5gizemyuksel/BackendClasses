namespace Question3;

class Program
{

    static string Word(string word)
    {

        char[] tersWord = word.ToCharArray();

        Array.Reverse(tersWord);
        foreach (char words in tersWord)
        {
            System.Console.Write(words);
        }
        return word;
    }
    static void Main(string[] args)
    {
        Word("gizem");
    }
}
