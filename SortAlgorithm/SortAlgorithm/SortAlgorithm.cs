using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public abstract class SortAlgorithm
    {
        protected int[] array = new int[0];

        protected virtual string AlgorithmName()
        {
            return string.Empty;
        }

        protected virtual void Sort()
        {
            return;
        }

        protected virtual void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public void Print(int[] data)
        {
            array = data;

            Sort();

            Console.WriteLine(AlgorithmName());

            foreach (int current in array)
            {
                Console.Write($"{current}\t");
            }

            Console.WriteLine("\n");
        }
    }
}
