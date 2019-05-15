using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class SelectionSort : SortAlgorithm
    {
        protected override string AlgorithmName()
        {
            return "選擇排序法";
        }

        protected override void Sort()
        {
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
        }
    }
}
