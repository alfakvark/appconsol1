﻿using System;
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
            sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.ReadLine();
        }

        /**
         *   Sorting the array
         */
        public static void sort(int[] array)
        {

        }
    }

}