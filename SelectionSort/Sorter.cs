using System;

// ReSharper disable InconsistentNaming
namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            RecursiveSelectionSort(array, 0);
        }

        public static void RecursiveSelectionSort(this int[]? array, int startIndex)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (startIndex < array.Length - 1)
            {
                int minIndex = FindMinimumIndex(array, startIndex);
                int temp = array[startIndex];
                array[startIndex] = array[minIndex];
                array[minIndex] = temp;
                RecursiveSelectionSort(array, startIndex + 1);
            }
        }

        private static int FindMinimumIndex(this int[]? array, int startIndex)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int minIndex = startIndex;

            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
