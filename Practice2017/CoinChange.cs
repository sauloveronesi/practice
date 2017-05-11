using System.Collections.Generic;

namespace Practice2017
{
    public class CoinChange
    {
        public int MakeChange(int[] coins, int amount)
        {
            return MakeChange(coins, amount, 0, new Dictionary<string, int>());
        }

        public int MakeChange(int[] coins, int amount, int index, Dictionary<string, int> memo)
        {
            if (amount == 0)
                return 1;

            if (index >= coins.Length)
                return 0;

            var key = amount + "|" + index;

            if (memo.ContainsKey(key))
                return memo[key];

            int amountForThisCoin = 0;
            int ways = 0;

            while (amountForThisCoin <= amount)
            {
                var remaining = amount - amountForThisCoin;
                ways += MakeChange(coins, remaining, index + 1, memo);
                amountForThisCoin += coins[index];
            }

            memo[key] = ways;

            return ways;
        }
    }
}
