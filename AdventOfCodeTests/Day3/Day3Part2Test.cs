using System;
using NUnit.Framework;

namespace AdventOfCode.Day3
{
    [TestFixture]
    public class Day3Part2Test
    {
        [Test]
        public void Solution()
        {
            var day3 = new Day3Part2(361527);
            Console.WriteLine(day3.GetSolution());
        }
    }
}