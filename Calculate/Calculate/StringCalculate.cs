using System;
using System.Collections.Generic;

namespace Calculate
{
    public class StringCalculate
    {
        private int total = 0;
        private List<string> delimetr;
        List<int> negativeValue = new List<int>();
        private const int IGNORED_BIGGEST_NUMBER = 1000;
        protected int Total
        {
            get { return total; }
            set { total = value; }
        }
        public StringCalculate()
        {
        }

        public int Add(string inputData)
        {
            delimetr = GetDelimetr(inputData);
            string[] terms = inputData.Split(delimetr.ToArray(), StringSplitOptions.None);
            GetSum(terms);
            NegativeNumbersCheck();
            EmptyStringCheck(inputData);

            return Total;
        }

        private void NegativeNumbersCheck()
        {
            if (negativeValue.Count > 0)
            {
                throw new Exception($"negatives not allowed: {String.Join(", ", negativeValue.ToArray())}");
            }
        }

        private static List<string> GetDelimetr(string inputData)
        {
            var delimetr = new List<string> { ",", "\n" };
            var nextDelimetr = "";
            var startPositionDelimetr = 0;
            var endPositionDelimetr = 0;
            var customDelimetr = "";
            if (inputData.StartsWith("//["))
            {
                do
                {
                    startPositionDelimetr = inputData.IndexOf('[', startPositionDelimetr);
                    if (startPositionDelimetr < 0)
                    {
                        break;
                    }
                    endPositionDelimetr = inputData.IndexOf(']', startPositionDelimetr);
                    if(endPositionDelimetr < 0)
                    {
                        break;
                    }

                    if(endPositionDelimetr - startPositionDelimetr> 0)
                    {
                        nextDelimetr = inputData
                        .Substring(startPositionDelimetr, endPositionDelimetr - startPositionDelimetr);
                        customDelimetr = nextDelimetr
                            .TrimStart('[')
                            .TrimEnd(']');
                    }
                    else
                    {
                        break;
                    }

                    startPositionDelimetr = endPositionDelimetr;

                    delimetr.Add(customDelimetr);

                }
                while (nextDelimetr != "");
                

            }
            else if (inputData.StartsWith("//"))
            {
                delimetr.Add(inputData[2].ToString());
            }
            

            return delimetr;
        }

        private void GetSum(string[] terms)
        {
            
            foreach (var item in terms)
            {

                if (int.TryParse(item, out int numb))
                {
                    if(numb < 0)
                    {
                        negativeValue.Add(numb);
                    }
                    else if(numb >= IGNORED_BIGGEST_NUMBER)
                    {
                        continue;
                    }
                    else
                    {
                        Total += numb;
                    }

                }
            }
           
        }

        private void EmptyStringCheck(string inputData)
        {
            if (inputData == "")
                Total = 0;
        }
    }
}