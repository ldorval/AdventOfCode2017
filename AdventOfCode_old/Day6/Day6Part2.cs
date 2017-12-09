using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day6
{
    public class Day6Part2
    {
        private readonly List<int> input;

        public Day6Part2(List<int> input)
        {
            this.input = input;
        }

        public int GetCycles()
        {
            var currentBanks = input;
            var previousResults = new List<List<int>>();

            do
            {
                previousResults.Add(new List<int>(currentBanks));
                var maxValue = currentBanks.Max();
                var maxIndex = currentBanks.IndexOf(maxValue);
                Redistribute(maxIndex, maxValue, currentBanks);

            } while (!previousResults.Any(b => AreEquivalent(currentBanks, b)));

            var cycles = 0;
            var initialState = new List<int>(currentBanks);

            do
            {
                var maxValue = currentBanks.Max();
                var maxIndex = currentBanks.IndexOf(maxValue);
                Redistribute(maxIndex, maxValue, currentBanks);

                cycles++;
            } while (!AreEquivalent(initialState, currentBanks));

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