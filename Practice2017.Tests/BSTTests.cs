using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice2017.Tests
{
    [TestClass]
    public class BSTTests
    {
        [TestMethod]
        public void TestIsBst()
        {
            var node = new BinaryTreeNode(10);
            node.InsertLeft(6).InsertRight(8);
            node.InsertRight(20).InsertLeft(18).InsertLeft(12).InsertRight(14);

            bool isBst = BST.IsBST(node);

            Assert.AreEqual(true, isBst);
        }

        [TestMethod]
        public void TestIsNotBst()
        {
            var node = new BinaryTreeNode(10);
            node.InsertLeft(6).InsertRight(8);
            node.InsertRight(20).InsertLeft(18).InsertLeft(12).InsertRight(1224);

            bool isBst = BST.IsBST(node);

            Assert.AreEqual(false, isBst);
        }

        [TestMethod]
        public void Test2ndLargest()
        {
            var node = new BinaryTreeNode(10);
            node.InsertLeft(6).InsertRight(8);
            node.InsertRight(20).InsertLeft(18).InsertLeft(12).InsertRight(14);

            var n = BST.SecondLargest(node);

            Assert.AreEqual(18, n);
        }

        [TestMethod]
        public void Test2ndLargest_2()
        {
            var node = new BinaryTreeNode(10);
            node.InsertLeft(6).InsertLeft(3).InsertLeft(2);

            var n = BST.SecondLargest(node);

            Assert.AreEqual(6, n);
        }

        [TestMethod]
        public void Test2ndLargest_3()
        {
            var node = new BinaryTreeNode(10);
            var six = node.InsertLeft(6);

            six.InsertRight(9);
            six.InsertLeft(3).InsertLeft(2);

            var n = BST.SecondLargest(node);

            Assert.AreEqual(6, n);
        }
    }
}
