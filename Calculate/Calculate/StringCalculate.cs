using System;
using System.Collections.Generic;

namespace Calculate
{
    public class StringCalculate
    {
        private int total = 0;
        private List<char> delimetr = new List<char>();
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
            string[] terms = inputData.Split(delimetr.ToArray());
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

        private static List<char> GetDelimetr(string inputData)
        {
            var delimetr = new List<char> { ',', '\n' };
            if (inputData.StartsWith("//"))
            {
                delimetr.Add(inputData[2]);
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