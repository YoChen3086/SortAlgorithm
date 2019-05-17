using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class ShellSort : SortAlgorithm
    {
        protected override string AlgorithmName()
        {
            return "希爾排序法";
        }

        protected override void Sort_SmallToBig()
        {
            array = originalArray;

            int i, j, tmp;
            int gap = array.Length / 2;
            for (; gap > 0; gap = gap / 2)
            {
                for (i = gap; i < array.Length; i++)
                {
                    //插入排序法 
                    tmp = array[i];
                    for (j = i; j >= gap && tmp < array[j - gap]; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = tmp;
                }
            }

            PrintArray();
        }

        protected override void Sort_BigToSmall()
        {
            array = originalArray;

            int i, j, tmp;
            int gap = array.Length / 2;
            for (; gap > 0; gap = gap / 2)
            {
                for (i = gap; i < array.Length; i++)
                {
                    //插入排序法 
                    tmp = array[i];
                    for (j = i; j >= gap && tmp > array[j - gap]; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = tmp;
                }
            }

            PrintArray();
        }
    }
}
