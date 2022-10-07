using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chernovik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3,-1,4,0,-5,-1 };
            int[] sortarr = quicksort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(", ", sortarr));
        }
        static int[] quicksort(int[] arr,int minim,int maxim)
        {
            if (minim>= maxim)
            {
                return arr;
            }
            int pivoindex = getpivoindex(arr, minim, maxim);
            quicksort(arr, pivoindex+1, maxim);
            quicksort(arr,minim, pivoindex-1);
            return arr;
        }
        static int getpivoindex(int[] arr, int minim, int maxim)
        {
            int pivo = minim - 1;
            for (int i = minim; i < maxim; i++)
            {
                if (arr[i] < arr[maxim])
                {
                    pivo++;
                    swap(ref arr[i], ref arr[pivo]);
                }
                
            }
            pivo++;
            swap(ref arr[pivo], ref arr[maxim]);
            return pivo;
        }
        static void swap(ref int left,ref int right)
        {
            int a = left;
            left = right;
            right = a;
        }
    }
}
