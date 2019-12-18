using System;

namespace WarmUp
{
    public class CloudJumping
    {
        static int jumpingOnClouds(int[] c)
        {
            int count = 0;
            for (int i = 0; i < c.Length;)
            {

                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }

                count++;
            }
            return count - 1;
        }


        public static void Main()
        {
            int[] a = { 0, 0, 0, 0, 1, 0 };
            Console.WriteLine(jumpingOnClouds(a));
        }

    }
}