using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day2Part2
    {
        private List<string> lines;

        public Day2Part2(string input)
        {
            lines = input.Split(new [] { "\r\n" }, StringSplitOptions.None).ToList();
        }

        public int GetSum()
        {
            var sum = 0;
            
            foreach (var line in lines)
            {
                var stringNumbers = line.Split('\t');
                var numbers = stringNumbers.Select(s => Convert.ToInt32(s));

                foreach (var firstNumber in numbers)
                {
                    foreach (var secondNumber in numbers)
                    {
                        if (firstNumber != secondNumber && firstNumber % secondNumber == 0)
                        {
                            sum += firstNumber / secondNumber;
                        }
                    }
                }
            }

            return sum;
        }
    }
}