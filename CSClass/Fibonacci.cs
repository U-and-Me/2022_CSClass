using System;
using System.Collections.Generic;

namespace CSClass
{
    public class Fibonacci
    {

        private static Dictionary<int, long> memo = new Dictionary<int, long>();

        public static long Get(int n)
        {
            if(n < 0) return 0;
            if(n == 1) return 1;

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }
            else
            {
                long value = Get(n - 1) + Get(n - 1);
                memo[n] = value;
                return value;
            }
        }
    }
}