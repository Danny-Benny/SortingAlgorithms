namespace Heapsort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            HeapSort(arr);

            Console.WriteLine("Seřazené pole:");
            PrintArray(arr);
        }
        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            //tady si vytvorim heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
            //extrahuju
            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;  
            int l = 2 * i + 1;  
            int r = 2 * i + 2;  

            //pokud je levy vetsi nez koren
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }
            //pokud je pravy vetsi nez vsechny pred nim
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }
            //kdyz neni nejvetsim prvkem heapu
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
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