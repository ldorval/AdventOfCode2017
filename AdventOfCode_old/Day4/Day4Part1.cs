using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day4Part1
    {
        private readonly List<string> passphrases;

        public Day4Part1(List<string> passphrases)
        {
            this.passphrases = passphrases;
        }

        public int ValidPassphraseCount()
        {
            var invalidPasswords = 0;
            
            foreach (var passphrase in passphrases)
            {
                var words = passphrase.Split(' ');
                foreach (var word in words)
                {
                    if (words.ToList().FindAll(w => w == word).Count >= 2)
                    {
                        invalidPasswords++;
                        break;
                    }                                        
                }
            }

            return passphrases.Count - invalidPasswords;
        }
    }
}