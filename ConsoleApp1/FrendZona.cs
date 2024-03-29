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
            int[] even = { 2, 4, 6, 8 };
            int[] prime = { 1, 3, 5, 7, 11, 13 };

            int[] merged = Merge(even, prime);

            for (int i = 0; i < merged.Length; i++)
            {
                Console.Write(merged[i] + ", ");
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

        public static void Shuffle(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int indexFrom = rnd.Next(0, array.Length);
                int indexTo = rnd.Next(0, array.Length);

                int c = array[indexTo];
                array[indexTo] = array[indexFrom];
                array[indexFrom] = c;
            }
        }

        /**
         *  Write a function that merges two sorted lists into a new sorted list. 
         *  [1,4,6],[2,3,5] → [1,2,3,4,5,6]. 
         *  You can do this quicker than concatenating them followed by a sort. 
         */
        public static int[] Merge(int[] arrA, int[] arrB)
        {
            int resultLength = arrA.Length + arrB.Length;
            int[] result = new int[resultLength];
            int aIndex = 0, bIndex = 0;
            for (int i=0; i<resultLength; i++)
            {
                if(bIndex>=arrB.Length || aIndex < arrA.Length && arrA[aIndex]<arrB[bIndex])
                {
                    result[i] = arrA[aIndex];
                    aIndex++;
                }
                else
                {
                    result[i] = arrB[bIndex];
                    bIndex++;
                }
            }
            return result;
        }
    }

}
