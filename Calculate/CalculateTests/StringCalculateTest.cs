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
        public void Input_EmptyString_0returned()
        {
            var calculate = new StringCalculate();
            int expected = 0;
            string inputData = "";

            Assert.AreEqual(calculate.Add(inputData), expected);
            
        }

        [Test]
        public void Input_OneNumberInString1_1returned()
        {
            var calculate = new StringCalculate();
            int expected = 1;
            string inputData = "1";

            Assert.AreEqual(calculate.Add(inputData), expected);

        }

        [Test]
        public void Input_TwoNumberInString_1and2_3returned()
        {
            var calculate = new StringCalculate();
            int expected = 3;
            string inputData = "1,2";

            Assert.AreEqual(calculate.Add(inputData), expected);

        }
    }
}