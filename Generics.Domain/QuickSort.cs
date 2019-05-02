using System;

namespace Generics.Domain
{

    public static class QuickSort<T> where T : IComparable
    {

        public static void Sort(T[] input) 
        {
            partionAndSort(input, 0, input.Length-1);    
        }

        private static void partionAndSort(T[] input, int left, int right)
        {
            int i = left, j = right;
            T pivot = input[(left + right) / 2];

            while (i <= j)
            {
                while (input[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (input[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    T tmp = input[i];
                    input[i] = input[j];
                    input[j] = tmp;

                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                partionAndSort(input, left, j);
            }

            if (i < right)
            {
                partionAndSort(input, i, right);
            }
        }
    }
}
