using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 5, 10, 1, 3, 48, 20, 99, 100, 5, 3, 0, -50 };
            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write($"{unsortedArray[i]} ");
            }
            Console.WriteLine();

            int[] sortedArray = Sort(unsortedArray);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] Sort(int[] unsortedArray)
        {
            int length = unsortedArray.Length;

            for (int i = 0; i < length-1; i++)
            {
                for (int j = 0; j < length-1-i; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j+1])
                    {
                        int temp = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = temp;
                    }
                }
            }
            return unsortedArray;
        }
    }


}
