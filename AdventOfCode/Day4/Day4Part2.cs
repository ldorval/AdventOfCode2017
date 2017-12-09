using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day4Part2
    {
        private readonly List<string> passphrases;

        public Day4Part2(List<string> passphrases)
        {
            this.passphrases = passphrases;
        }

        public int ValidPassphraseCount()
        {
            var invalidPasswords = 0;
            
            foreach (var passphrase in passphrases)
            {
                invalidPasswords += ValidatePassphrase(passphrase);
            }

            return passphrases.Count - invalidPasswords;
        }

        private int ValidatePassphrase(string passphrase)
        {
            var words = passphrase.Split(' ');
            var orderedWords = words.Select(SortLettersInWord);

            var hashSet = new HashSet<string>(orderedWords);

            if (hashSet.Count != words.Length)
            {
                return 1;
            }
            
            return 0;
        }

        private string SortLettersInWord(string word)
        {
            return new string(word.ToCharArray().OrderBy(l => l).ToArray());
        }
    }
}