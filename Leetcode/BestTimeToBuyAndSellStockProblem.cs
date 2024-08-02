using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BestTimeToBuyAndSellStockProblem
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;
            var maxProfit = 0;
            int minBuy = prices[0];
            for (var sellIndex = 1; sellIndex < prices.Length; sellIndex++)
            {
                if (prices[sellIndex] < minBuy) minBuy = prices[sellIndex];
                else if (prices[sellIndex] - minBuy > maxProfit)
                    maxProfit = prices[sellIndex] - minBuy;
            }
            return maxProfit;
        }
    }
}
