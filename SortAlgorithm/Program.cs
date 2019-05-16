using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class Program
    {
        private static Random random = new Random();
        private static int[] question = new int[10];

        static void Main(string[] args)
        {
            MakeQuestion();

            List<SortAlgorithm> algorithmList = new List<SortAlgorithm>();
            algorithmList.Add(new SelectionSort());
            algorithmList.Add(new InsertionSort());
            algorithmList.Add(new BubbleSort());
            //algorithmList.Add(new ShellSort());
            algorithmList.Add(new ShakerSort());
            algorithmList.Add(new QuickSort());

            foreach (SortAlgorithm algorithm in algorithmList)
            {
                algorithm.Print(question);
            }

            Console.ReadLine();
        }

        private static void MakeQuestion()
        {
            Console.WriteLine("原始題目:");
            for (int i = 0; i < question.Length; i++)
            {
                question[i] = random.Next(1, 100);
                Console.Write($"{question[i]}\t");
            }
            Console.WriteLine("\n");
        }
    }
}
