using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class SortAlgorithms
    {
        public void Switch(int[] data, int m, int n)//good think to know is that arrays are alwyas reference type(even when data is value type)
        {
            int temp;

            temp = data[m];
            data[m] = data[n];
            data[n] = temp;
        }

        public void IntArrayBubbleSort(int[] data)//O(N squared) this algorithm is slow and not commonly used, but it does have historical interest
        {
            int i, j;
            int n = data.Length;

            for (j = n - 1; j > 0; j--) //starting from the back of the array
            {
                for (i = 0; i < j; i++)// for each element loop up to array length
                {
                    if (data[i] > data[i + 1])//if value at i is bigger than value at i + 1, then switch
                        Switch(data, i, i + 1);
                }
            }
        }
        
        private int IntArrayMin(int[] data, int start)//finds the position of the minimum value in the rest of the array.
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])// if value at position is smaller than minimum position
                    minPos = pos;
            return minPos;
        }

        //visits each item in the array to find out whether it is the minimum of all the elements after it
        public void IntArraySelectionSort(int[] data)//it's cool algorithm where double loop iterations are getting smaller after each iteration
        {
            int i;
            int n = data.Length;

            for (i = 0; i < n - 1; i++)
            {
                int k = IntArrayMin(data, i);//find the position of minimum value
                if (i != k)//if current index is not index of minimum value, switch
                    Switch(data, i, k);
            }
        }

        public void IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int n = data.Length;

            for (j = 1; j < n; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)//loop while i is greater than 0 AND value at i is less than value at i - 1
                {
                    Switch(data, i, i - 1);
                }
            }
        }

        //everyones favorite lol
        private void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; //int
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Switch(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }
    }
}
