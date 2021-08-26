using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculate
{
    public class StringCalculate
    {
        private int result;
        private const int IGNORED_BIGGEST_NUMBER = 1000;

        public int Add(string inputData)
        {
            EmptyStringCheck(inputData);
            int[] numberArray = GetArray(inputData);

            NegativeNumbersCheck(inputData);

            GetSum(numberArray);

            return result;
        }

        private void EmptyStringCheck(string inputData)
        {
            if (inputData == "")
                result = 0;
        }

        private int[] GetArray(string inputData)
        {
            var numbers = Regex.Matches(inputData, @"\d+");
            List<int> numberList = new List<int>();
            foreach (var elem in numbers)
            {
                numberList.Add(int.Parse(elem.ToString()));
            }

            return numberList.ToArray();
        }

        private static void NegativeNumbersCheck(string inputData)
        {
            List<int> negativeValues = new List<int>();

            var negativeNumbers = Regex.Matches(inputData, @"-\d+");
            foreach (var elem in negativeNumbers)
            {
                negativeValues.Add(int.Parse(elem.ToString()));
            }

            if (negativeValues.Count > 0)
            {
                throw new Exception($"negatives not allowed: {String.Join(", ", negativeValues.ToArray())}");
            }
        }

        private void GetSum(int[] numberArray)
        {
            foreach (var numb in numberArray)
            {
                if (numb < IGNORED_BIGGEST_NUMBER)
                {
                    result += numb;
                }
            }
        }




        

    }
}