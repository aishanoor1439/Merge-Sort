using System;

namespace MergeSort
{
    public class MergeSort
    {
        void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            int ii = 0, jj = 0;
            int k = l;

            while (ii < n1 && jj < n2)
            {
                if (L[ii] <= R[jj])
                {
                    arr[k] = L[ii];
                    ii++;
                }
                else
                {
                    arr[k] = R[jj];
                    jj++;
                }
                k++;
            }

            while (ii < n1)
            {
                arr[k] = L[ii];
                ii++;
                k++;
            }

            while (jj < n2)
            {
                arr[k] = R[jj];
                jj++;
                k++;
            }
        }

        public void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }

        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };

            Console.WriteLine("Given Array");
            printArray(arr);

            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
    }
}
