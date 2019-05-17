using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class SelectionSort : SortAlgorithm
    {
        public SelectionSort(int[] data) : base(data)
        {
        }

        protected override string AlgorithmName()
        {
            return "選擇排序法";
        }

        protected override void Sort_SmallToBig()
        {
            array = originalArray;

            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    Swap(i, min);
                }
            }

            PrintArray();
        }

        protected override void Sort_BigToSmall()
        {
            array = originalArray;

            for (int i = 0; i < array.Length; i++)
            {
                int max = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                    }
                }
                if (i != max)
                {
                    Swap(i, max);
                }
            }

            PrintArray();
        }
    }
}
