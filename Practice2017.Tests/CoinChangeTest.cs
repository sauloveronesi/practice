using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice2017.Tests
{
    [TestClass]
    public class CoinChangeTest
    {
        [TestMethod]
        public void TestCoinChange1()
        {
            var coins = new int[] { 1, 2, 4 };
            var amount = 3;

            var ways = new CoinChange().MakeChange(coins, amount);

            Assert.AreEqual(2, ways);
        }

        [TestMethod]
        public void TestNoWay()
        {
            var coins = new int[] { 111, 222, 433 };
            var amount = 20;

            var ways = new CoinChange().MakeChange(coins, amount);

            Assert.AreEqual(0, ways);
        }
    }
}
