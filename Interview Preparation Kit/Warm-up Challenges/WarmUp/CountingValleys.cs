using System;

namespace WarmUp
{
    public class CountingValleys
    {
        static int countingValleys(int n, string s)
        {
            int seaLevel = 0;
            bool track = true;
            int numberOfValleys = 0;

            foreach (char eachStep in s)
            {
                if (eachStep.Equals('U'))
                {
                    seaLevel++;
                }
                else if (eachStep.Equals('D'))
                {
                    seaLevel--;
                }

                if (seaLevel >= 0)
                {
                    track = true;
                }

                if (track == true && seaLevel < 0)
                {
                    track = false;
                    numberOfValleys++;
                }
            }

            return numberOfValleys;

        }

        public static void Main()
        {
            Console.WriteLine(countingValleys(5, "UDDDUDUU"));
        }
    }
}