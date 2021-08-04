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
        public void Input_OneNumberInString2_2returned()
        {
            var calculate = new StringCalculate();
            int expected = 2;
            string inputData = "2";

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

        [Test]
        public void Input_TwoNumberInString_3and5_8returned()
        {
            var calculate = new StringCalculate();
            int expected = 8;
            string inputData = "3,5";

            Assert.AreEqual(calculate.Add(inputData), expected);

        }

        [Test]
        public void Input_UnknownNumberAmount3_3and5and7_15returned()
        {
            var calculate = new StringCalculate();
            int expected = 15;
            string inputData = "3,5,7";

            Assert.AreEqual(calculate.Add(inputData), expected);

        }

        [Test]
        public void Input_UnknownNumberAmount4_3and5and7and2_17returned()
        {
            var calculate = new StringCalculate();
            int expected = 17;
            string inputData = "3,5,7,2";

            Assert.AreEqual(calculate.Add(inputData), expected);

        }

        [Test]
        public void Input_UnknownNumberAmount6_3and5and7and1and12and8_36returned()
        {
            var calculate = new StringCalculate();
            int expected = 36;
            string inputData = "3,5,7,1,12,8";

            Assert.AreEqual(calculate.Add(inputData), expected);

        }

        [Test]
        public void Input_UnknownNumberAmount_3_WithNewLines_1andNewLineand2and3_6returned()
        {
            var calculate = new StringCalculate();
            int expected = 6;
            string inputData = "1\n2,3";

            Assert.AreEqual(calculate.Add(inputData), expected);

        }

    }
}