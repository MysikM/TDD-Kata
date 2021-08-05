using Calculate;
using NUnit.Framework;
using System;

namespace CalculateTests
{
    public class Tests
    {
        StringCalculate calculate;
        [SetUp]
        public void Setup()
        {
            calculate = new StringCalculate();
        }

        [TestCase("",0)]
        public void Input_EmptyString_0returned(string inputData, int expected)
        {

            Assert.AreEqual(calculate.Add(inputData), expected);
            
        }

        [TestCase("1",1)]
        [TestCase("2",2)]
        public void Input_OneNumberInString_returnedParse(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);

        }


        [TestCase("1,2",3)]
        [TestCase("3,5",8)]
        public void Input_TwoNumberInString__returnedSum(string inputData, int expected)
        {

            Assert.AreEqual(calculate.Add(inputData), expected);

        }


        [TestCase("3,5,7", 15)]
        [TestCase("3,5,7,2", 17)]
        [TestCase("3,5,7,1,12,8", 36)]
        public void Input_UnknownNumberAmount_returnedSum(string inputData, int expected)
        {

            Assert.AreEqual(calculate.Add(inputData), expected);

        }


        [TestCase("1\n2,3", 6)]
        [TestCase("12\n2,3", 17)]
        [TestCase("12\n2\n3", 17)]
        [TestCase("12\n2\n3,1", 18)]
        [TestCase("10\n10\n10,10\n10", 50)]
        public void Input_UnknownNumberAmount_WithNewLines_returnedSum(string inputData, int expected)
        {

            Assert.AreEqual(calculate.Add(inputData), expected);

        }
        [TestCase("//;\n1;2", 3)]
        [TestCase("//}\n1}22}2}12", 37)]
        [TestCase("//'\n100'10'1", 111)]
        public void Input_UnknownNumberAmount_2_WithDifferentDelimiters_DelimiterandNewLine1andDelimiterand2_3returned(string inputData, int expected)
        {

            Assert.AreEqual(calculate.Add(inputData), expected);

        }
        [TestCase("-1,2,3", "negatives not allowed: -1")]
        [TestCase("-1,2,-3", "negatives not allowed: -1, -3")]
        [TestCase("//'\n100'-10'-1", "negatives not allowed: -10, -1")]
        [TestCase("10\n10\n10,-10\n10", "negatives not allowed: -10")]
        public void Input_NegativeNumber_returnedThrowsExeption(string inputData, string trhrowsMessage)
        {

            var exeption = Assert.Throws<Exception>(() => calculate.Add(inputData));
            Assert.AreEqual(trhrowsMessage, exeption.Message);


        }

    }
}