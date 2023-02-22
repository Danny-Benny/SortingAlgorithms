namespace Bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            BubbleSort(arr);

            Console.WriteLine("Seřazené pole:");
            PrintArray(arr);
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            //opakuju cyklus dokud se pole neseradi
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                { 
                    //porovnavam sousedici prvky a prohodim je pokud jsou ve spatnem poradi
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}