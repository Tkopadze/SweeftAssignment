using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class variants
    {
        public int CountVariants(int stairCount)
        {
            if (stairCount <= 1)
            {
                return 1; // There is only one way to climb 0 or 1 stair.
            }

            int[] dp = new int[stairCount + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= stairCount; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[stairCount];
        }
    }

}
