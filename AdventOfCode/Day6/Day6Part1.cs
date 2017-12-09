using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day6
{
    public class Day6Part1
    {
        private readonly List<int> input;

        public Day6Part1(List<int> input)
        {
            this.input = input;
        }

        public int GetCycles()
        {
            var currentBanks = input;
            var previousResults = new List<List<int>>();
            var cycles = 0;

            do
            {
                previousResults.Add(new List<int>(currentBanks));
                var maxValue = currentBanks.Max();
                var maxIndex = currentBanks.IndexOf(maxValue);
                Redistribute(maxIndex, maxValue, currentBanks);

                cycles++;
            } while (!previousResults.Any(b => AreEquivalent(currentBanks, b)));

            return cycles;
        }

        private void Redistribute(int maxIndex, int maxValue, List<int> currentBanks)
        {
            var toRedistribute = maxValue;
            var currentIndex = maxIndex;
            currentBanks[maxIndex] = 0;

            currentIndex = NextIndex(currentIndex, currentBanks);

            while (toRedistribute > 0)
            {
                currentBanks[currentIndex]++;
                currentIndex = NextIndex(currentIndex, currentBanks);
                
                toRedistribute--;
            }
        }

        private int NextIndex(int currentIndex, List<int> currentBanks)
        {
            if (currentIndex == currentBanks.Count - 1)
                return 0;
            
            return currentIndex + 1;
        }

        private bool AreEquivalent(List<int> a, List<int> b)
        {
            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }
    }
}