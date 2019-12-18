using System;
using System.Collections.Generic;
using System.IO;

namespace WarmUp
{
    public class SockMerchant
    {
        static int sockMerchant(int n, int[] ar)
        {
            return GetValue(SortArray(ar));
        }

        static int[] SortArray(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }

        static int GetValue(int[] ar)
        {

            int noPairs = 0;
            int count = 0;
            List<int> numberList = new List<int>();
            List<int> pairList = new List<int>();

            for (int primaryIndex = 0; primaryIndex < ar.Length - 1;)
            {
                count = 0;
                for (int secondaryIndex = primaryIndex + 1; secondaryIndex < ar.Length; secondaryIndex++)
                {
                    if (ar[primaryIndex] == ar[secondaryIndex])
                    {
                        count++;
                    }
                    else
                    {
                        if (count > 0)
                        {
                            numberList.Add(ar[primaryIndex]);
                            pairList.Add(count + 1);
                        }
                        primaryIndex = secondaryIndex;
                        break;
                    }

                    if (secondaryIndex + 1 == ar.Length)
                    {
                        primaryIndex = secondaryIndex;
                        numberList.Add(ar[primaryIndex]);
                        pairList.Add(count + 1);
                    }
                }
            }

            foreach (int n in pairList)
            {
                noPairs += n / 2;
            }

            return noPairs;
        }

        public static void Main()
        {
            int[] a = { 5, 9, 5, 4, 7, 2, 6, 3, 2, 6, 4, 1, 5, 6, 8, 9, 6, 7, 4, 2, 5, 3, 6, 9, 8, 9, 5, 6, 3, 1, 7, 4, 7, 5, 6, 9, 3, 2, 1, 4, 5, 6, 8, 7, 9, };
            Console.WriteLine(GetValue(SortArray(a)));
        }
    }
}