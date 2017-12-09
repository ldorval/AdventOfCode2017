using System.Collections.Generic;

namespace AdventOfCode.Day5
{
    public class Day5Part2
    {
        private readonly List<int> input;

        public Day5Part2(List<int> input)
        {
            this.input = input;
        }

        public int GetSteps()
        {
            var steps = 0;
            var index = 0;

            while (index >= 0 && index < input.Count)
            {
                var offset = input[index]; 
                var nextIndex = index + offset;

                if (offset >= 3)
                    input[index]--;
                else
                    input[index]++;
                
                index = nextIndex;
                steps++;
            }

            return steps;
        }
    }
}