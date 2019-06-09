using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,c;


            Console.WriteLine("Insert the number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            for(int i=2; i<=a; i++)
            {
                for(int j=2; j<=a; j++)
                {
                    c = i * j;
                    Console.Write(j+"*"+i+"="+c+"\t");

                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("ВАШЕ ЧИСЛО, "+a+"!");
            Console.ReadKey();
            Console.WriteLine("GITHUB privaet");
        }

    }
}
