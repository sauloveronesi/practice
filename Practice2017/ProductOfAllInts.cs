namespace Practice2017
{
    public class ProductOfAllInts
    {
        public int[] CalculateNaive(int[] values)
        {
            var val = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int res = 1;

                for (int j = 0; j < values.Length; j++)
                {
                    if (i != j)
                    {
                        res *= values[j];
                    }
                }

                val[i] = res;
            }

            return val;
        }

        public int[] CalculateGreedy(int[] values)
        {
            var results = new int[values.Length];

            int product = 1;
            
            for (int i = 0; i < values.Length; i++)
            {
                results[i] = product;
                product *= values[i];
            }

            product = 1;

            for (int i = values.Length - 1; i >= 0; i--)
            {
                results[i] *= product;
                product *= values[i];
            }

            return results;
        }
    }
}
