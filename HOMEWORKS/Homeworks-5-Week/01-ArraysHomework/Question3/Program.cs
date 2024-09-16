using System.ComponentModel;

namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        // Random rnd = new Random();
        // int[] arr = new int[10];
        // int[] negativeArr = new int[10];
        // int[] positiveArr = new int[10];
        // int ngtCounter = 0;
        // int pstCounter = 0;

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     arr[i] = rnd.Next(-100, 100);
        // }
        // System.Console.WriteLine("rastgele atanmış dizi:");
        // foreach (int item in arr)
        // {
        //     System.Console.WriteLine(item);
        // }

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (arr[i] < 0)
        //     {
        //         negativeArr[ngtCounter] = arr[i];
        //         ngtCounter++;
        //     }


        // }
        // Array.Resize(ref negativeArr, ngtCounter);
        // if (ngtCounter == 0)
        // {

        //     System.Console.WriteLine("Negatif sayı girilmemiştir. ");

        // }
        // System.Console.WriteLine("Negatif sayılar dizisi: ");
        // foreach (int ngtItem in negativeArr)
        // {
        //     System.Console.WriteLine(ngtItem);
        // }
        // Array.Resize(ref negativeArr, ngtCounter);

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (arr[i] > 0)
        //     {
        //         positiveArr[pstCounter] = arr[i];
        //         pstCounter++;
        //     }


        // }
        // Array.Resize(ref positiveArr, pstCounter);
        // if (pstCounter == 0)
        // {

        //     System.Console.WriteLine("Pozitif sayı girilmemiştir.");

        // }
        // System.Console.WriteLine("Pozitif sayılar dizisi");
        // foreach (int pstItem in positiveArr)
        // {
        //     System.Console.WriteLine(pstItem);
        // }

        int[] arr = new int[10];
        int[] positiveArr = new int[10];
        int[] negativeArr = new int[10];

        int ngtCounter = 0;
        int pstCounter = 0;
        Random rnd = new Random();
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-100, 100);

        }

        System.Console.WriteLine("rastgele atanmış dizi: ");
        foreach (int item in arr)
        {
            System.Console.WriteLine(item);
        }

        while (index < arr.Length)
        {
            if (arr[index] < 0)
            {
                negativeArr[ngtCounter] = arr[index];
                ngtCounter++;
            }
            if (arr[index] > 0)
            {
                positiveArr[pstCounter] = arr[index];
                pstCounter++;
            }
            index++;
        }
        Array.Resize(ref negativeArr, ngtCounter);
        System.Console.WriteLine("Negatif sayılar dizisi: ");
        foreach (int ngtItem in negativeArr)
        {
            System.Console.WriteLine(ngtItem);
        }
        Array.Resize(ref positiveArr, pstCounter);
        System.Console.WriteLine("pozitif sayılar dizisi: ");
        foreach (int pstItem in positiveArr)
        {
            System.Console.WriteLine(pstItem);
        }





    }
}
