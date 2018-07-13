using System;

namespace tdd.roman.numerals
{
    public class RomanNumeralHelper
    {
        public static string ToRoman(int arabic)
        {
            if (arabic < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (arabic >= 4000)
            {
                throw new ArgumentOutOfRangeException();
            }

            var result = string.Empty;
            var remainingValue = arabic;

            while (remainingValue >= 1000)
            {
                result = "M";
                remainingValue = remainingValue - 1000;
            }

            while (remainingValue >= 500)
            {
                result += "D";
                remainingValue = remainingValue - 500;
            }

            while (remainingValue >= 100 && remainingValue != 200)
            {
                result = result + "C";
                remainingValue = arabic - 100;
            }

            if (remainingValue >= 50)
            {
                result += "L";
                remainingValue = arabic - 50;
            }

            while (remainingValue >= 10)
            {
                result = result + "X";
                remainingValue = remainingValue - 10;
            }

            if (remainingValue == 9)
            {
                result = result + "IX";
                remainingValue = remainingValue - 9;
            }

            if (remainingValue >= 5)
            {
                result = result + "V";
                remainingValue = remainingValue - 5;
            }

            if (remainingValue == 4)
            {
                result = result + "IV";
                remainingValue = remainingValue - 4;
            }

            while (remainingValue <= 3 && remainingValue > 0)
            {
                result = result + "I";
                remainingValue = remainingValue - 1;
            }

            return result;
        }

        public static int ToArabic(string roman)
        {
            throw new NotImplementedException();
        }
    }
}
