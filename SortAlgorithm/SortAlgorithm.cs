using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public abstract class SortAlgorithm
    {
        protected int[] originalArray = new int[0];
        protected int[] array = new int[0];

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

        public void Print(int[] data)
        {
            originalArray = data;

            Console.WriteLine(AlgorithmName());

            Console.WriteLine("小到大");
            Sort_SmallToBig();

            Console.WriteLine();

            Console.WriteLine("大到小");
            Sort_BigToSmall();

            Console.WriteLine("\n");
        }
    }
}
