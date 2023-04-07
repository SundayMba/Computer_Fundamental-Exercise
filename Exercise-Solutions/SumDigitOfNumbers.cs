using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Solutions
{
    internal class SumDigitOfNumbers
    {
        public static int sumDigit(int n)
        {
            int sum = 0;
            int whn = n;
            int rem = 0;

            while (n > 9)
            {
                while (whn > 0)
                {
                    rem = whn % 10;
                    whn /= 10;
                    sum += rem;
                    Console.WriteLine("rem: {0}, sum: {1}, whole: {2}", rem, sum, whn);
                }
                n = sum;
                whn = sum;
                if (sum > 9) sum = 0;
            }
            return sum;
        }
    }
}
