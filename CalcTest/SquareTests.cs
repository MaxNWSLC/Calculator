using NUnit.Framework;
using Calculator;

namespace CalcTest
{
    public class SquareTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void SquareTest_1()
        {
            int n = 1;
            long expected = 1;
            long result = Form1.Squared(n);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SquareTest_2()
        {
            int n = 2;
            long expected = 4;
            long result = Form1.Squared(n);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SquareTest_10()
        {
            int n = 10;
            long expected = 100;
            long result = Form1.Squared(n);

            Assert.AreEqual(expected, result);
        }
    }
}