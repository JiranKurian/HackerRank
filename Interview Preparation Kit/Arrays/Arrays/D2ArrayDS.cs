using System;

namespace Arrays
{

    public class D2ArrayDS
    {
        static int hourglassSum(int[][] arr)
        {

            int val = 0;
            int max = int.MinValue;


            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < arr.GetLength(0) - 2; column++)
                {
                    val = arr[row][column] + arr[row][column + 1] + arr[row][column + 2]; // first row
                    val += arr[row + 1][column + 1]; // second row
                    val += arr[row + 2][column] + arr[row + 2][column + 1] + arr[row + 2][column + 2]; // third row

                    if (val > max)
                    {
                        max = val;
                    }
                }
            }

            return max;

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

            int[][] jagged_arr = new int[6][]; // jagged array

            jagged_arr[0] = new int[] { -1, -1, 0, -9, -2, -2 };
            jagged_arr[1] = new int[] { -2, -1, -6, -8, -2, -5 };
            jagged_arr[2] = new int[] { -1, -1, -1, -2, -3, -4 };
            jagged_arr[3] = new int[] { -1, -9, -2, -4, -4, -5 };
            jagged_arr[4] = new int[] { -7, -3, -3, -2, -9, -9 };
            jagged_arr[5] = new int[] { -1, -3, -1, -2, -4, -5 };

            Console.WriteLine(hourglassSum(jagged_arr));
        }
    }
}