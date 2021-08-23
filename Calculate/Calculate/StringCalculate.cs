using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculate
{
    public class StringCalculate
    {
        private int result;
       // private List<string> delimetr;
        List<int> negativeValue = new List<int>();
        private const int IGNORED_BIGGEST_NUMBER = 1000;

        public int Add(string inputData)
        {
            EmptyStringCheck(inputData);
            //delimetr = GetDelimetr(inputData);
            int[] numberArray = GetArray(inputData);
            GetSum(numberArray);
            NegativeNumbersCheck();

            return result;
        }

        private void GetSum(int[] numberArray)
        {
            foreach (var numb in numberArray)
            {
                if (numb < 0)
                {
                    negativeValue.Add(numb);
                }
                else if (numb < IGNORED_BIGGEST_NUMBER)
                {
                    result += numb;
                }
            }
        }

        private void EmptyStringCheck(string inputData)
        {
            if (inputData == "")
                result = 0;
        }

        //private static List<string> GetDelimetr(string inputData)
        //{
        //    var listDelimetr = new List<string> { ",", "\n" };
        //    if (inputData.StartsWith("//["))
        //    {
        //        GetAllowMultipleDelimiters(inputData, listDelimetr);
        //    }
        //    else if (inputData.StartsWith("//"))
        //    {
        //        listDelimetr.Add(inputData[2].ToString());
        //    }
        //    return listDelimetr;
        //}

        //private static void GetAllowMultipleDelimiters(string inputData, List<string> listDelimetr)
        //{
        //    int startPositionDelimetr = 0;
        //    do
        //    {
        //        startPositionDelimetr = inputData.IndexOf('[', startPositionDelimetr);

        //        if (CheckNextDelimetr(startPositionDelimetr))
        //            break;

        //        var endPositionDelimetr = inputData.IndexOf(']', startPositionDelimetr);

        //        var delimetr = inputData.Substring(startPositionDelimetr, endPositionDelimetr - startPositionDelimetr).TrimStart('[').TrimEnd(']');

        //        startPositionDelimetr = endPositionDelimetr;

        //        listDelimetr.Add(delimetr);
        //    } while (true);
        //}
        //private static bool CheckNextDelimetr(int startPositionNextDelimetr)
        //{
        //    if (startPositionNextDelimetr == -1)
        //        return true;
        //    return false;
        //}
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
        

        private void NegativeNumbersCheck()
        {
            if (negativeValue.Count > 0)
            {
                throw new Exception($"negatives not allowed: {String.Join(", ", negativeValue.ToArray())}");
            }
        }
    }
}