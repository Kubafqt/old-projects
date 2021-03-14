using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class radix
    {

        //static void Main(string[] args)
        //{
        //    int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66, 4564 };
        //    int n = arr.Length;
        //    radixsort(arr, n);
        //    print(arr, n);
        //    Console.ReadKey();
        //}

        public static void lsd(int[] arr, int n)
        {
            int m = getMax(arr, n);

            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }

        static int getMax(int[] arr, int n)  // A utility function to get maximum value in arr[] 
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        static void countSort(int[] arr, int n, int exp)
        {
            int i;
            int[] output = new int[n];  // output array 
            int[] count = new int[10];
            foreach (var x in count)
            { count[x] = 0; }
            //for (var x = 0; x <= count.Length; x++)
            //    count[x] = 0;

            //Store count of occurrences in count[] 
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            //Change count[i] so that count[i] now contains actual position of this digit in output[] 
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            //Build the output array 
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            //Copy the output array to arr[], so that arr[] now contains sorted numbers according to curent digit 
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        //static void print(int[] arr, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //        Console.WriteLine(arr[i] + " ");
        //}



        //zdroj: https://en.wikipedia.org/wiki/Radix_sort#Implementation_in_java


    }
}

