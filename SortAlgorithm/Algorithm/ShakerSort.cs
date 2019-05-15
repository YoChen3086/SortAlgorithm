using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class ShakerSort : SortAlgorithm
    {
        protected override string AlgorithmName()
        {
            return "搖晃排序法";
        }

        protected override void Sort()
        {
            int left = 0;
            int right = array.Length - 1;
            int shift = 0;

            while (left < right)
            {
                for (var i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {  //將最大值往右排
                        Swap(i, i + 1);
                        shift = i;
                    }
                }
                right = shift;
                for (var i = right; i > left; i--)
                {
                    if (array[i] < array[i - 1])
                    {  //將最小值往左排
                        Swap(i, i - 1);
                        shift = i;
                    }
                }
                left = shift;
            }
        }
    }
}
