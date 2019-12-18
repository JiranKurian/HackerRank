using System;
using WarmUp;

namespace ClassRunner
{
    class Program
    {

        SockMerchant sockMerchant = new SockMerchant();

        CountingValleys countingValleys = new CountingValleys();

        CloudJumping cloudJumping = new CloudJumping();

        RepeatedString repeatedString = new RepeatedString();

        static void Main(string[] args)
        {
            // SockMerchant.Main();
            // CountingValleys.Main();
            // CloudJumping.Main();
            RepeatedString.Main();
        }
    }
}
