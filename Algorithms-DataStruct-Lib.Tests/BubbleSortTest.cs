
using DataStructures_Algorithm;
using NUnit.Framework;
using System;

namespace Algorithms_DataStruct_Lib.Tests
{
    [TestFixture]
    public class BubbleSortTest
    {
        [Test]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestForBubbleSort(BubbleSort.BubbleSortImplementation);
        }

        private int[][] SampleData()
        {
            int[][] sampleData = new int[9][];
            sampleData[0] = new[] { 1 };
            sampleData[1] = new[] { 2, 1 };
            sampleData[2] = new[] { 2, 1, 3 };
            sampleData[3] = new[] { 1, 1, 1 };
            sampleData[4] = new[] { 2, -1, 3, 3 };
            sampleData[5] = new[] { 4, -5, 3, 3 };
            sampleData[6] = new[] { 0, -5, 3, 3 };
            sampleData[7] = new[] { 0, -5, 3, 0 };
            sampleData[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return sampleData;
        }

        private void RunTestForBubbleSort(Action<int[]> sort)
        {
            foreach (int[] sampleData in SampleData())
            {
                sort(sampleData);
                CollectionAssert.IsOrdered(sampleData);
                PrintOut(sampleData);
            }
        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("-----TRACE-----\n");
            foreach (int el in array)
            {
                TestContext.WriteLine(el + " ");
            }
            TestContext.WriteLine("\n------------------\n");
        }
    }
}
