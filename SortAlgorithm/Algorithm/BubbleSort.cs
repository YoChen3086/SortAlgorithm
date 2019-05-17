using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class BubbleSort : SortAlgorithm
    {
        public BubbleSort(int[] data) : base(data)
        {
        }

        protected override string AlgorithmName()
        {
            return "氣泡排序法";
        }

        protected override void Sort_SmallToBig()
        {
            bool flag = true;
            for (int i = 0; i < array.Length - 1 && flag; i++)
            {
                flag = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(j, j + 1);
                        flag = true;
                    }
                }
            }
        }

        protected override void Sort_BigToSmall()
        {
            bool flag = true;
            for (int i = 0; i < array.Length - 1 && flag; i++)
            {
                flag = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        Swap(j, j + 1);
                        flag = true;
                    }
                }
            }
        }
    }
}
