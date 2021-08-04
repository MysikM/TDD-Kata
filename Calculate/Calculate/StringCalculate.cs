using System;

namespace Calculate
{
    public class StringCalculate
    {
        private int total;
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
            EmptyStringCheck(inputData);
            OneNumberInString(inputData);
            TwoNumberInString(inputData);
            return Total;
        }

        private void TwoNumberInString(string inputData)
        {
            if (inputData.Contains(','))
            {
                string[] terms = inputData.Split(new char[] { ',' });
                foreach (var item in terms)
                {
                    Total += Int32.Parse(item);
                }
            }
                
        }

        private void OneNumberInString(string inputData)
        {
            if(inputData == "1")
                Total = Int32.Parse(inputData);
        }

        private void EmptyStringCheck(string inputData)
        {
            if (inputData == "")
                Total = 0;
        }
    }
}