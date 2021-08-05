using System;
using System.Collections.Generic;

namespace Calculate
{
    public class StringCalculate
    {
        private int total = 0;
        private List<char> delimetr = new List<char>();
        protected int Total
        {
            get { return total; }
            set { total = value; }
        }
        public StringCalculate()
        {
        }

        public double Add(string inputData)
        {
            delimetr = GetDelimetr(inputData);
            string[] terms = inputData.Split(delimetr.ToArray());
            GetSum(terms);
            EmptyStringCheck(inputData);

            return Total;
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
                    Total += numb;

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