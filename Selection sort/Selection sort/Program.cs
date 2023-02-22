internal class Program
{
    static void Main(string[] args)
    {
 
        int[] arr = { 64, 25, 12, 22, 11 };


        SelectionSort(arr);

 
        Console.WriteLine("Seřazené pole:");
        PrintArray(arr);
    }
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        //postupne prochazim pole a ve zbyle casti pole hledam minima
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    // Nalezení nového minima
                    minIndex = j;
                }
            }

            //prohazuju aktualni prvek s prvkem s minimem
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
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