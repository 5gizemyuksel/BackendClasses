namespace Question11;

class Program
{
    static int Findvowels(string word)
    {
        char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
        int counter = 0;

        foreach (char vowel in word)
        {
            if (Array.Exists(vowels, element => element == vowel))
            {
                counter++;
            }
        }

        System.Console.WriteLine(counter + " tane sesli harf içerir.");
        return counter;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir kelime giriniz: ");
        string word = Console.ReadLine();
        Findvowels(word);
    }
}
