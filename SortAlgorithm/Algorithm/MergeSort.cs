using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    public class MergeSort : SortAlgorithm
    {
        public MergeSort(int[] data) : base(data)
        {
        }

        protected override string AlgorithmName()
        {
            return "合併排序法";
        }

        protected override void Sort_SmallToBig()
        {
            array = originalArray;

            array = Merge(array);

            PrintArray();
        }

        protected override void Sort_BigToSmall()
        {
            array = originalArray;

            PrintArray();
        }

        private int[] Merge(int[] array)
        {
            if (array.Length > 1)
            {
                // 如果資料超過1筆		
                int[] leftData = new int[array.Length / 2];
                int[] rightData = new int[array.Length - leftData.Length];
                var middle = array.Length / 2;

                // 將資料分割成左右子串列
                for (var i = 0; i < middle; i++)
                    leftData[i] = array[i];
                for (var j = middle; j < array.Length; j++)
                    rightData[j - middle] = array[j];

                leftData = Merge(leftData);    // 對左子串列作合併排序
                rightData = Merge(rightData);  // 對右子串列作合併排序
                return MergeLeftAndRight(leftData, rightData); // 將左右子串列作完合併的結果合併
            }

            return array;
        }

        private int[] MergeLeftAndRight(int[] leftData, int[] rightData)
        {
            int[] sortedData = new int[leftData.Length + rightData.Length];
            int leftIndex = 0;
            int rightIndex = 0;

            // 一一比對leftData和rightData每個元素的大小
            // 將較小者依序填入sortedData
            for (var i = 0; i < leftData.Length + rightData.Length; i++)
            {
                //如果leftData已填完, 就填入rightData的資料
                if (leftIndex == leftData.Length)
                    sortedData[i] = rightData[rightIndex++];

                //如果rightData已填完, 就填入leftData的資料
                else if (rightIndex == rightData.Length)
                    sortedData[i] = leftData[leftIndex++];

                // 如果leftData < rightData,則填入leftData的資料   
                else if (leftData[leftIndex] < rightData[rightIndex])
                    sortedData[i] = leftData[leftIndex++];

                // 如果rightData < leftData,則填入leftData的資料
                else
                    sortedData[i] = rightData[rightIndex++];
            }
            return sortedData;
        }
    }
}
