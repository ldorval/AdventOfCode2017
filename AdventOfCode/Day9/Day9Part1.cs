using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public class Day9Part1
    {
        private string input;

        public Day9Part1(string input)
        {
            this.input = input;
        }

        public int GetGarbageCount()
        {
            RemoveCancelledCharacters();
            
            var sum = 0;
            foreach (var match in Regex.Matches(input, "<.*?>"))
            {
                sum += match.ToString().Length - 2;
            }

            return sum;
        }

        public int GetScore()
        {
            RemoveCancelledCharacters();
            RemoveGarbage();
            var score = 0;
            var level = 0;

            foreach (var character in input)
            {
                if (character == '{')
                    level++;
                else if (character == '}')
                {
                    score += level--;
                }
            }

            return score;
        }

        private void RemoveGarbage()
        {
            input = Regex.Replace(input, "<.*?>", string.Empty);
        }

        private void RemoveCancelledCharacters()
        {
            input = Regex.Replace(input, "!.", string.Empty);
        }
    }
}