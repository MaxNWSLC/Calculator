using NUnit.Framework;
using Calculator;

namespace CalcTest
{
    public class CubicTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void CubicTest_1()
        {
            int n = 1;
            long expected = 1;
            long result = Form1.Cubed(n);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CubicTest_2()
        {
            int n = 2;
            long expected = 8;
            long result = Form1.Cubed(n);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CubicTest_10()
        {
            int n = 10;
            long expected = 1000;
            long result = Form1.Cubed(n);

            Assert.AreEqual(expected, result);
        }
    }
}