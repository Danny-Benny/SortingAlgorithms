namespace Counting_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
          
            CountingSort(arr);

            Console.WriteLine("Seřazené pole:");
            PrintArray(arr);
        }
        static void CountingSort(int[] arr)
        {
            int n = arr.Length;

            //najdu nejvetsi cislo
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[] count = new int[max + 1];

            //spocitam vyskyt kazdeho cisla
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }

            //upravim pole count aby obsahovalo pozice
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            int[] sorted = new int[n];

            //naplnim pomocne pole
            for (int i = 0; i < n; i++)
            {
                sorted[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            //prepius puvodni pole
            for (int i = 0; i < n; i++)
            {
                arr[i] = sorted[i];
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