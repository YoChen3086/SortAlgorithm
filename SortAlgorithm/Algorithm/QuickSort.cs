using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class QuickSort : SortAlgorithm
    {
        public QuickSort(int[] data) : base(data)
        {
        }

        protected override string AlgorithmName()
        {
            return "快速排序法";
        }

        protected override void Sort_SmallToBig()
        {
            array = originalArray;

            // 以data[left]為Pivot，left相當於最左邊第一個元素
            SubSort_SmallToBig(0, array.Length - 1);

            PrintArray();
        }

        protected override void Sort_BigToSmall()
        {
            array = originalArray;

            // 以data[left]為Pivot，left相當於最左邊第一個元素
            SubSort_BigToSmall(0, array.Length - 1);

            PrintArray();
        }

        private void SubSort_SmallToBig(int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right + 1;
                while (true)
                {
                    // 向右找小於Pivot的數值的位置
                    while (i + 1 < array.Length && array[++i] < array[left]) ;

                    // 向左找大於Pivot的數值的位置
                    while (j - 1 > -1 && array[--j] > array[left]) ;

                    // 若i,j的位置交叉
                    //     代表範圍內，Pivot右邊已無比Pivot小的數值
                    //     代表範圍內，Pivot左邊已無比Pivot大的數值            
                    if (i >= j)
                        break;

                    // 將比Pivot大的數值換到右邊，比Pivot小的數值換到左邊
                    Swap(i, j);
                }
                Swap(left, j);    // 將Pivot移到中間
                SubSort_SmallToBig(left, j - 1);    // 對左子串列進行快速排序
                SubSort_SmallToBig(j + 1, right);   // 對右子串列進行快速排序
            }
        }

        private void SubSort_BigToSmall(int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right + 1;
                while (true)
                {
                    // 向右找大於Pivot的數值的位置
                    while (i + 1 < array.Length && array[++i] > array[left]) ;

                    // 向左找小於Pivot的數值的位置
                    while (j - 1 > -1 && array[--j] < array[left]) ;

                    // 若i,j的位置交叉
                    //     代表範圍內，Pivot右邊已無比Pivot小的數值
                    //     代表範圍內，Pivot左邊已無比Pivot大的數值            
                    if (i >= j)
                        break;

                    // 將比Pivot大的數值換到右邊，比Pivot小的數值換到左邊
                    Swap(i, j);
                }
                Swap(left, j);    // 將Pivot移到中間
                SubSort_BigToSmall(left, j - 1);    // 對左子串列進行快速排序
                SubSort_BigToSmall(j + 1, right);   // 對右子串列進行快速排序
            }
        }
    }
}
