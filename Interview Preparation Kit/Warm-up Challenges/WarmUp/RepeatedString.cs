using System;
using System.Text;

namespace WarmUp
{
    public class RepeatedString
    {
        static long repeatedString(string s, long n)
        {

            long totalRepeationCount = 0;
            long remainingLength = 0;

            totalRepeationCount = n / s.Length;
            remainingLength = n % s.Length;

            if (remainingLength == 0)
            {
                return totalRepeationCount * GetCount(s);
            }
            else
            {
                return totalRepeationCount * GetCount(s) + GetCount(s, remainingLength);
            }

        }

        static long GetCount(string s)
        {
            long count = 0;
            foreach (char c in s)
            {
                if (c == 'a')
                {
                    count++;
                }
            }
            return count;
        }

        static long GetCount(string s, long n)
        {
            long count = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main()
        {
            Console.WriteLine(repeatedString("aba", 10));
        }

    }
}