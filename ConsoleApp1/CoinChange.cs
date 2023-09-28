using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CoinChange
    {
        public static int MinSplit(int amount)
        {
           
            int[] coins = { 50, 20, 10, 5, 1 };

            int[] dp = new int[amount + 1];
            for (int i = 1; i <= amount; i++)
            {
                dp[i] = int.MaxValue;
            }

   
            dp[0] = 0;

           
            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (i >= coin && dp[i - coin] != int.MaxValue)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount];
        }

     
        
    }

}
