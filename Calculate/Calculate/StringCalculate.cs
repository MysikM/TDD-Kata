using System;
using System.Collections.Generic;

namespace Calculate
{
    public class StringCalculate
    {
        private int total = 0;
        private char[] delimetr = { ',', '\n' };
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
            string[] terms = inputData.Split(delimetr);
            GetSum(terms);
            EmptyStringCheck(inputData);

            return Total;
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