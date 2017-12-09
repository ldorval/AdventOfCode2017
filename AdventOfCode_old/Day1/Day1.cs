using System;
using System.Linq;

namespace AdventOfCode
{
    public class Day1
    {
        private readonly string input;
        private readonly int step;

        public Day1(string input, int step)
        {
            this.input = input;
            this.step = step;
        }

        public int Sum()
        {
            var digits = input.ToCharArray();
            return digits.Select((digit, index) => AddToSum(digits, index)).Sum();
        }
        
        private int AddToSum(char[] digits, int currentIndex)
        {
            var nextIndex = GetNextIndex(currentIndex, digits.Length);
            return digits[currentIndex] == digits[nextIndex] ? (int) Char.GetNumericValue(digits[nextIndex]) : 0;
        }

        private int GetNextIndex(int index, int length)
        {
            return index + step < length ? index + step : step - (length - index);
        }
    }
}