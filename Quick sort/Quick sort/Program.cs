namespace Quick_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Seřazené pole:");
            PrintArray(arr);
        }
        static void QuickSort(int[] arr, int low, int high)
        {
            //pokud obsahuje vice nez jeden prvek
            if (low < high)
            {
                //najdu pivot a rozdelim ho
                int pivot = Partition(arr, low, high);

                //rekurzivne volam
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }
        static int Partition(int[] arr, int low, int high)
        {
            //posldni prvek ajko pivot
            int pivot = arr[high];
            //index na ktery vlozim pivot
            int i = (low - 1);

            //porovnavam s pivotem
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            //vymenim pivot s prvkem na indexu i+1
            int swap = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swap;

            return i + 1;
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