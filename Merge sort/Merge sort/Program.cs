namespace Merge_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            MergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Seřazené pole:");
            PrintArray(arr);
        }
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right) 
            {
                int middle = (left + right) / 2; //najdu stred

                MergeSort(arr, left, middle); //rekurzivne seradim levou polovinu
                MergeSort(arr, middle + 1, right); //--||-- pravou polivinu

                Merge(arr, left, middle, right); //sloucim
            }
        }
        static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] temp = new int[right - left + 1]; //pole pro slouceni

            int i = left, j = middle + 1, k = 0; //urcuju indexi

            while (i <= middle && j <= right) //dokud nejsem u konce apson jedne z polovin
            {
                if (arr[i] <= arr[j]) //pokud je v levo mensi nebo rovnz
                {
                    temp[k] = arr[i]; 
                    i++; 
                }
                else //else v prave polivine 
                {
                    temp[k] = arr[j]; 
                    j++; 
                }
                k++;
            }

            while (i <= middle) //pokud jsem neukoncil pruchod levou pol.
            {
                temp[k] = arr[i]; 
                k++;
                i++;
            }

            while (j <= right) //--||-- pravou pol.
            {
                temp[k] = arr[j];
                k++;
                j++;
            }

            for (int p = 0; p < temp.Length; p++)
            {
                arr[left + p] = temp[p];
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