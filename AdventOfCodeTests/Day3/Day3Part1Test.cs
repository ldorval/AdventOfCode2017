using System;
using NUnit.Framework;

namespace AdventOfCode.Day3
{
    [TestFixture]
    public class Day3Part1Test
    {
        [Test]
        public void Example1()
        {
            var day3 = new Day3Part1(1);
            Assert.That(day3.GetSteps(), Is.EqualTo(0));
        }
        
        [Test]
        public void Example2()
        {
            var day3 = new Day3Part1(12);
            Assert.That(day3.GetSteps(), Is.EqualTo(3));
        }
        
        [Test]
        public void Example3()
        {
            var day3 = new Day3Part1(23);
            Assert.That(day3.GetSteps(), Is.EqualTo(2));
        }
        
        [Test]
        public void Example4()
        {
            var day3 = new Day3Part1(1024);
            Assert.That(day3.GetSteps(), Is.EqualTo(31));
        }

        [Test]
        public void Solution()
        {
            var day3 = new Day3Part1(361527);
            Console.WriteLine(day3.GetSteps());
        }
    }
}