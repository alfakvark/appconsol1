using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FrendZona
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1,3,2,4,5,7,2,1,3,10,22,3,4,7};
            Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.ReadLine();
        }

        /**
         *   Sorting the array
         */
        public static void Sort(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                bool hasSwap = false;
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int c = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = c;
                        hasSwap = true;
                    }
                }
                if (!hasSwap)
                {
                    break;
                }
                    
            }
        }
    }

}
