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
        [TestCase("2,1000", 2)]
        [TestCase("2,1000,3", 5)]
        [TestCase("//'\n1000'10'1", 11)]
        [TestCase("10\n1000\n10,10\n10", 40)]

        public void Input_NumberBiggest1000_returnedSumignoredNumberNiggest1000(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);

        }
        [TestCase("//[***]\n1***2***3", 6)]
        public void Input_UnknownNumberAmount_WithDifferentDelimitersAnySize_returnedSum(string inputData, int expected)
        {

            Assert.AreEqual(calculate.Add(inputData), expected);

        }
        [TestCase("//[***][%]\n1***2%3", 6)]
        [TestCase("//[***][%]\n1***2%3***2", 8)]
        [TestCase("//[;;][**]\n1**2;;3**2;;1000", 8)]


        public void Input_UnknownNumberAmount_WithAnyDifferentDelimitersAnySize_returnedSum(string inputData, int expected)
        {

            Assert.AreEqual(calculate.Add(inputData), expected);

        }



    }
}