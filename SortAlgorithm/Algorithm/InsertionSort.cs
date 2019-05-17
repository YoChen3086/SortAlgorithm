using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class InsertionSort : SortAlgorithm
    {
        public InsertionSort(int[] data) : base(data)
        {
        }

        protected override string AlgorithmName()
        {
            return "插入排序法";
        }

        protected override void Sort_SmallToBig()
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j > -1 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

        protected override void Sort_BigToSmall()
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j > -1 && temp > array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
    }
}
