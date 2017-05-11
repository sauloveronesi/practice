using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice2017.Tests
{
    [TestClass]
    public class StockSellTests
    {
        [TestMethod]
        public void Test1()
        {
            double[] stockPrices = { 10, 7, 5, 8, 11, 9 };

            var stockSell = new StockSell();

            var result = stockSell.GetMaxProfit(stockPrices);

            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(11, result[1]);
        }

        [TestMethod]
        public void TestBig()
        {
            double[] stockPrices = new double[100000];

            Random rand = new Random();

            for (int i = 0; i < stockPrices.Length; i++)
            {
                stockPrices[i] = rand.NextDouble() * (10000 - 100) + 100;
            }

            stockPrices[20] = 50;
            stockPrices[5000] = 11000;

            var stockSell = new StockSell();

            var result = stockSell.GetMaxProfit(stockPrices);

            Assert.AreEqual(50, result[0]);
            Assert.AreEqual(11000, result[1]);
        }

        [TestMethod]
        public void TestBigCalculate()
        {
            double[] stockPrices = new double[100000];

            Random rand = new Random();

            for (int i = 0; i < stockPrices.Length; i++)
            {
                stockPrices[i] = rand.NextDouble() * (10000 - 100) + 100;
            }

            stockPrices[20] = 50;
            stockPrices[5000] = 11000;

            var stockSell = new StockSell();

            var result = stockSell.CalculateMaxProfit(stockPrices);

            Assert.AreEqual(11000 - 50, result);
        }

        [TestMethod]
        public void TestNull()
        {
            double[] stockPrices = null;

            var stockSell = new StockSell();

            var result = stockSell.GetMaxProfit(stockPrices);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestEmpty()
        {
            double[] stockPrices = new double[0];

            var stockSell = new StockSell();

            var result = stockSell.GetMaxProfit(stockPrices);

            Assert.IsNull(result);
        }
    }
}
