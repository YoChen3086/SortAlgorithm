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
            array = originalArray;

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

            PrintArray();
        }

        protected override void Sort_BigToSmall()
        {
            array = originalArray;


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

            PrintArray();
        }
    }
}
