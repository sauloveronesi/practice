namespace Practice2017
{
    public class StockSell
    {
        public double[] GetMaxProfit(double[] prices)
        {
            if (prices == null || prices.Length < 1)
                return null;

            int min = 0;
            int maxPosition = 0;
            
            double max = int.MinValue;

            for (int i = 1; i < prices.Length; i++)
            {
                var sum = prices[i] - prices[min];

                if (prices[i] < prices[min])
                    min = i;

                if (sum > max)
                {
                    maxPosition = i;
                    max = sum;
                }
            }

            return new double[] { prices[min], prices[maxPosition] };
        }
    }
}
