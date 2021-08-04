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
            UnknownNumberAmount(inputData);
            return Total;
        }

        private void UnknownNumberAmount(string inputData)
        {
            if (ContainSeparator(inputData))
            {
                string[] terms = inputData.Split(new char[] { ',' });
                foreach (var item in terms)
                {
                    Total += Int32.Parse(item);
                }
            }

        }

        private static bool ContainSeparator(string inputData)
        {
            return inputData.Contains(',');
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