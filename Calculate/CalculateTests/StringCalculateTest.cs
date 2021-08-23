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
        public void Add_EmptyString_returns_0(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);   
        }

        [TestCase("1",1)]
        public void Add_1_returns_0(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }

        [TestCase("3,5",8)]
        public void Add_3and5_returns_8(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }


        [TestCase("3,5,7,1,12,8", 36)]
        public void Add_3and5and7and1and12and8_returns_36(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }

        [TestCase("10\n10\n10,10\n10", 50)]
        public void Add_10and10and10and10and10_returns_50(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }

        [TestCase("//;\n1;2", 3)]
        public void Add_1and2WithDifferentDelimiters_returns_3(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }


        [TestCase("10\n1000", 10)]
        public void Add_10and1000_returns_10(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }

        [TestCase("//[***]\n1***900", 901)]

        public void Add_1and900WithDifferentDelimitersAnySize_returns_901(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }

        [TestCase("//[***][%]\n1***2%3", 6)]
        public void Add_1and2and3WithAnyDifferentDelimitersAnySize_returns_6(string inputData, int expected)
        {
            Assert.AreEqual(calculate.Add(inputData), expected);
        }

    }
}