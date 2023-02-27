using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravnqvaneNaSimvolniMasivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string a = Console.ReadLine().Replace(" ", "");
            string b = Console.ReadLine().Replace(" ", "");
            int sravniResult = string.Compare(a, b);
            if (sravniResult < 0)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }
    }
}
