namespace Practice2017
{
    public class StockSell
    {
        public double CalculateMaxProfit(double[] prices)
        {
            var maxProfitValues = GetMaxProfit(prices);

            if (maxProfitValues == null)
                return 0;

            return maxProfitValues[1] - maxProfitValues[0];
        }

        public double[] GetMaxProfit(double[] prices)
        {
            if (prices == null || prices.Length < 1)
                return null;

            int minPosition = 0;
            int maxPosition = 0;
            
            double maxSoFar = int.MinValue;

            for (int i = 1; i < prices.Length; i++)
            {
                var sum = prices[i] - prices[minPosition];

                if (prices[i] < prices[minPosition])
                    minPosition = i;

                if (sum > maxSoFar)
                {
                    maxPosition = i;
                    maxSoFar = sum;
                }
            }

            return new double[] { prices[minPosition], prices[maxPosition] };
        }
    }
}
