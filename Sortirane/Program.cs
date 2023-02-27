using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortirane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }
}
