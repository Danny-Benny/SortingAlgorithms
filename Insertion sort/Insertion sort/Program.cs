namespace Insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            InsertionSort(arr);

            Console.WriteLine("Seřazené pole:");
            PrintArray(arr);
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            //prochazim pole od druheo prvkui az po konec
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // posouvam prvky dokud nenarazim na klic
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}