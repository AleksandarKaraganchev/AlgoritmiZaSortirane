using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurseneNaElementVSortiranMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedN = int.Parse(Console.ReadLine());
            bool Found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchedN)
                {
                    Found = true;
                    break;
                }
            }
            if (Found)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
