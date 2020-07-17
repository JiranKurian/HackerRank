using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace Arrays
{
    public class ArrayManipulation
    {
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] resultArray = new long[n];
            long large = 0;
            for (int row = 0; row < queries.Length; row++)
            {
                for (int column = queries[row][0] - 1; column <= queries[row][1] - 1; column++)
                {
                    resultArray[column] += queries[row][2];
                }
            }
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (large < resultArray[i])
                {
                    large = resultArray[i];
                }
            }
            return large;
        }

        public static void Main()
        {
            int[,] arr = new int[6, 6] {
                {1, 1, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {1, 1, 1, 0, 0, 0},
                {0, 0, 2, 4, 4, 0},
                {0, 0, 0, 2, 0, 0},
                {0, 0, 1, 2, 4, 0}
            };  // normal array



            // Data Set 1 - 10000000 100000 - Result 2517519438
            // Data Set 2 - 4000 30000 - Result 7542539201



            /*int[][] jagged_arr = new int[lines.Length][]; // jagged array

            jagged_arr[0] = new int[] { 1, 2, 100 };
            jagged_arr[1] = new int[] { 2, 5, 100 };
            jagged_arr[2] = new int[] { 3, 4, 100 };*/

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Console.WriteLine("Start here:");

            string path = @"D:\HackerRank\Interview Preparation Kit\Arrays\Arrays\DataArrayManipulation1.txt";

            string[] lines = File.ReadAllLines(path);

            int[][] jagged_arr = new int[lines.Length][]; // jagged array

            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(' ');

                jagged_arr[i] = new int[] { int.Parse(words[0]), int.Parse(words[1]), int.Parse(words[2]) };
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Actual programs starts here");

            Console.WriteLine(arrayManipulation(10000000, jagged_arr));

            stopwatch.Stop();
            Console.WriteLine("Time taken to excecute actual program in milliseconds: " + stopwatch.Elapsed.Milliseconds);
            Console.WriteLine("Time taken to excecute complete program in milliseconds: " + stopwatch1.Elapsed.Milliseconds);
        }
    }
}