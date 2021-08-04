using Calculate;
using NUnit.Framework;

namespace CalculateTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_EmptyString_0retutned()
        {
            var calculate = new StringCalculate();
            int expected = 0;
            string inputData = "";

            Assert.AreEqual(calculate.Add(inputData), expected);
            
        }

    }
}