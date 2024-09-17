namespace Zoological_Aplication;

class Program
{
    static void Main(string[] args)
    {
        Giraffe giraffe = new Giraffe("Benekli", 8, "Zürafa");
        giraffe.MakeSound();

        Lion lion = new Lion("Pars", 6, "Aslan");
        lion.MakeSound();

        Elephant elephant = new Elephant("Lui", 4, "Fil");
        elephant.MakeSound();
    }
}
