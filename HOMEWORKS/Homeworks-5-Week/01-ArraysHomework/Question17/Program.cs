namespace Question17;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 70, 20, 90, 60, 50, 80, 70, 70 };
        int enBuyuk = 0;
        int buyuk = 0;
        int index = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            Array.Sort(arr);

            if (arr[i] > arr[index] && arr[i] != arr[index])
            {
                buyuk = arr[index];
                index++;
            }
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i] >= arr[j])
                {
                    enBuyuk = arr[i];
                }
            }

        }

        System.Console.WriteLine(buyuk);
        System.Console.WriteLine(enBuyuk);
    }
}
