namespace Questionpoint;

class Program
{
    static void Main(string[] args)
    {
        int[] arr= {1,3,5,6,-8,-9,10,12,-9,-10};
        int[] positiveArr= new int[10];
        int[] negativeArr= new int[10];

        int pstCounter=0;
        int ngtCounter=0;

        int index=0;

        while (index<arr.Length)
        {
            if (arr[index]<0)
            {
                negativeArr[ngtCounter]=arr[index];
                ngtCounter++;
            }
            if (arr[index]>0)
            {
                positiveArr[pstCounter]=arr[index];
                pstCounter++;
            }
            index++;
        }

          for (int i = 0; i < positiveArr.Length; i++)
          {
            System.Console.WriteLine(positiveArr[i]+ " ");
          }
           
           System.Console.WriteLine(positiveArr,0,pstCounter);
        
    }
}
