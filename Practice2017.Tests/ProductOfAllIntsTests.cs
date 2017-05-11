using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice2017.Tests
{
    [TestClass]
    public class ProductOfAllIntsTests
    {
        [TestMethod]
        public void TestCalcNaive()
        {
            var arr = new int[] { 1, 7, 3, 4 };
            var exp = new int[] { 84, 12, 28, 21 };

            var r = new ProductOfAllInts().CalculateNaive(arr);

            for (int i = 0; i < arr.Length; i++)
                Assert.AreEqual(exp[i], r[i]);
        }

        [TestMethod]
        public void TestCalcGreedy()
        {
            var arr = new int[] { 1, 7, 3, 4 };
            var exp = new int[] { 84, 12, 28, 21 };

            var r = new ProductOfAllInts().CalculateGreedy(arr);

            for (int i = 0; i < arr.Length; i++)
                Assert.AreEqual(exp[i], r[i]);
        }
    }
}
