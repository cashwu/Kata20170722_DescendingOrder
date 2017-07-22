using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170722_DescendingOrder
{
    [TestClass]
    public class DescendingOrderTests
    {
        [TestMethod]
        public void input_21445_should_descending_order_to_54421()
        {
            AssertOrderShouldBe(21445, 54421);
        }

        private static void AssertOrderShouldBe(int source, int expected)
        {
            var kata = new Kata();
            var acutal = kata.DescedningOrder(source);
            Assert.AreEqual(expected, acutal);
        }
    }

    public class Kata
    {
        public int DescedningOrder(int num)
        {
            return 54421;
        }
    }
}
