using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortAlgorithms sort = new SortAlgorithms();
            Random random = new Random();
            int randomSeed;

            int arraySize = 10000;
            Stopwatch watch = new Stopwatch();
            double elapsedTime;  // time in second, accurate to about millseconds
            int[] data = new int[arraySize];

            randomSeed = random.Next();
            IntArrayGenerate(data, randomSeed);
            watch.Reset();
            watch.Start();
            sort.IntArrayBubbleSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Bubble Sort: {0:F3}", elapsedTime);

            randomSeed = random.Next();
            IntArrayGenerate(data, randomSeed);
            watch.Reset();
            watch.Start();
            sort.IntArrayInsertionSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Insertion Sort: {0:F3}", elapsedTime);

            randomSeed = random.Next();
            IntArrayGenerate(data, randomSeed);
            watch.Reset();
            watch.Start();
            sort.IntArraySelectionSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Selection Sort: {0:F3}", elapsedTime);

            randomSeed = random.Next();
            IntArrayGenerate(data, randomSeed);
            watch.Reset();
            watch.Start();
            sort.IntArrayQuickSort(data);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Quick Sort: {0:F3}", elapsedTime);//on my cpu, it is 300 faster than bubble sort lol

            Console.ReadKey(true);

        }

        public static void IntArrayGenerate(int[] data, int randomSeed)
        { 
            Random r = new Random(randomSeed);
            for (int i = 0; i < data.Length; i++)
                data[i] = r.Next();
        }
    }
}
