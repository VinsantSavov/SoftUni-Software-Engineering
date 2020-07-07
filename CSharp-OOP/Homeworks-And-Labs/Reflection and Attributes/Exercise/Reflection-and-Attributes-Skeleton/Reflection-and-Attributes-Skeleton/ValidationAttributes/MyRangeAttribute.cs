using System;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;

            this.ValidRange(minValue, maxValue);
        }

        public override bool IsValid(object obj)
        {
            int value = (int)obj;

            return value >= minValue && value <= maxValue;
        }

        public bool ValidRange(int min, int max)
        {
            if(min > max)
            {
                return false;
            }

            return true;
        }
    }
}
