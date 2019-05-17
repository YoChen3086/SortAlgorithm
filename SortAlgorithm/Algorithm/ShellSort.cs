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

            int gap = array.Length / 2;

            while (gap > 0)
            {
                for (int k = 0; k < gap; k++)
                {
                    for (var i = k + gap; i < array.Length; i += gap)
                    {
                        for (var j = i - gap; j >= k; j -= gap)
                        {
                            if (array[j] > array[j + gap])
                                Swap(j, j + gap);
                            else
                                break;
                        }
                    }
                }
                gap = gap / 2;
            }

            PrintArray();
        }

        protected override void Sort_BigToSmall()
        {
            array = originalArray;

            int gap = array.Length / 2;

            while (gap > 0)
            {
                for (int k = 0; k < gap; k++)
                {
                    for (var i = k + gap; i < array.Length; i += gap)
                    {
                        for (var j = i - gap; j >= k; j -= gap)
                        {
                            if (array[j] < array[j + gap])
                                Swap(j, j + gap);
                            else
                                break;
                        }
                    }
                }
                gap = gap / 2;
            }

            PrintArray();
        }
    }
}
