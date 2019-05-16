using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class BubbleSort : SortAlgorithm
    {
        protected override string AlgorithmName()
        {
            return "氣泡排序法";
        }

        protected override void Sort_SmallToBig()
        {
            array = originalArray;

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

            PrintArray();
        }

        protected override void Sort_BigToSmall()
        {
            array = originalArray;

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

            PrintArray();
        }
    }
}
