using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public const int LINE_LENGTH = 120;
        public const int SEPARATOR_LEN = 4;

        static void Main1(string[] args) // disable entry point
        {
            for (int i = 0; i < 2; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                printTable(n);
            }
            Console.WriteLine("The end is near!");
        }

        public static void printTable(int n)
        {
            int maxlen = (n + " * " + n + " = " + n * n).Length;
            int maxUr = (LINE_LENGTH - maxlen) / (maxlen + SEPARATOR_LEN);
            for (int lastJ = 1; lastJ <= n; lastJ += maxUr)
            {
                for (int i = 1; i <= n; i++)
                {
                    int sep = 0;
                    for (int j = lastJ; sep < maxUr && j <= n; j++, sep++)
                    {
                        string ar = j + " * " + i + " = " + i * j;
                        Console.Write(ar + '\t');
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                // comment
            }
        }
    }
}
