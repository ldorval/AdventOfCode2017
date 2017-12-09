using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day2Part1
    {
        private List<string> lines;

        public Day2Part1(string input)
        {
            lines = input.Split(new [] { "\r\n" }, StringSplitOptions.None).ToList();
        }

        public int GetChecksum()
        {
            var sum = 0;

            foreach (var line in lines)
            {
                var numbers = line.Split('\t');
                
                var charArray = numbers
                    .Select(n => Convert.ToInt32(n))
                    .OrderBy(n => n).ToList();

                sum += charArray.Last() - charArray.First();
            }

            return sum;
        }
    }
}