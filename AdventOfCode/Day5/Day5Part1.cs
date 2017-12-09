using System.Collections.Generic;

namespace AdventOfCode.Day5
{
    public class Day5Part1
    {
        private readonly List<int> input;

        public Day5Part1(List<int> input)
        {
            this.input = input;
        }

        public int GetSteps()
        {
            var steps = 0;
            var index = 0;

            while (index >= 0 && index < input.Count)
            {
                var nextIndex = index + input[index];
                input[index]++;
                index = nextIndex;
                steps++;
            }

            return steps;
        }
    }
}