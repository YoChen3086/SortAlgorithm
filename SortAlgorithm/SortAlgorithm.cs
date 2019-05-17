using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public abstract class SortAlgorithm
    {
        protected int[] originalArray;
        protected int[] array;

        public SortAlgorithm(int[] data)
        {
            originalArray = new int[data.Length];
            array = new int[data.Length];

            data.CopyTo(originalArray, 0);
        }

        protected virtual string AlgorithmName()
        {
            return string.Empty;
        }

        protected virtual void Sort_SmallToBig()
        {
            return;
        }

        protected virtual void Sort_BigToSmall()
        {
            return;
        }

        protected virtual void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        protected void PrintArray()
        {
            foreach (int current in array)
            {
                Console.Write($"{current}\t");
            }
        }

        public void Print()
        {
            Console.WriteLine(AlgorithmName());
            
            Console.WriteLine("小到大");
            originalArray.CopyTo(array, 0);
            Sort_SmallToBig();

            Console.WriteLine();

            Console.WriteLine("大到小");
            originalArray.CopyTo(array, 0);
            Sort_BigToSmall();

            Console.WriteLine("\n");
        }
    }
}
