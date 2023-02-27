using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivaneNaPodredeniMasivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] merge = new int[arr.Length + arr1.Length];
            int i = 0;
            int f = 0;
            int k = 0;
            while (i < arr.Length && f < arr1.Length)
            {
                if (arr[i] < arr1[f])
                {
                    merge[k] = arr[i];
                    i++;
                }
                else
                {
                    merge[k] = arr1[f];
                    f++;
                }
                k++;
            }
            while (i < arr.Length)
            {
                merge[k] = arr[i];
                i++;
                k++;
            }

            while (f < arr1.Length)
            {
                merge[k] = arr1[f];
                f++;
                k++;
            }

            Console.WriteLine(string.Join(" ", merge));
        }
    }
}
