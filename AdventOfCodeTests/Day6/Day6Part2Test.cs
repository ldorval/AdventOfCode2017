using System;
using System.Collections.Generic;
using AdventOfCode.Day6;
using NUnit.Framework;

namespace AdventOfCodeTests.Day6
{
    [TestFixture]
    public class Day6Part2Test
    {
        [Test]
        public void Example1()
        {
            var input = new List<int> {0, 2, 7, 0};
            var day6 = new Day6Part2(input);

            Assert.That(day6.GetCycles(), Is.EqualTo(4));
        }

        [Test]
        public void Solution()
        {
            var input = new List<int> {14, 0, 15, 12, 11, 11, 3, 5, 1, 6, 8, 4, 9, 1, 8, 4};
            var day6 = new Day6Part2(input);

            Console.WriteLine(day6.GetCycles());
        }
    }
}