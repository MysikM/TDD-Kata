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
            inputData = CheckNewLines(inputData);
            UnknownNumberAmount(inputData);
            return Total;
        }

        private static string CheckNewLines(string inputData)
        {
            if (inputData.Contains("\n"))
                inputData = inputData.Replace("\n", ",");
            return inputData;
        }

        private void UnknownNumberAmount(string inputData)
        {
            if (CheckContainSeparator(inputData))
            {
                string[] terms = inputData.Split(new char[] { ',' });
                ParseAndAddResult(terms);
            }

        }

        private void ParseAndAddResult(string[] terms)
        {
            foreach (var item in terms)
            {
                Total += Int32.Parse(item);
            }
        }

        private static bool CheckContainSeparator(string inputData)
        {
            return inputData.Contains(',');
        }

        private void OneNumberInString(string inputData)
        {
            if(inputData.Length == 1)
                Total = Int32.Parse(inputData);
        }

        private void EmptyStringCheck(string inputData)
        {
            if (inputData == "")
                Total = 0;
        }
    }
}