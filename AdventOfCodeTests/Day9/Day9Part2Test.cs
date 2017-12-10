using System;
using System.IO;
using NUnit.Framework;
using AdventOfCode;

namespace AdventOfCodeTests
{
    public class Day9Part2Test
    {
        [Test]
        public void Example1()
        {
            var day9 = new Day9Part1("<>");
            Assert.That(day9.GetGarbageCount(), Is.EqualTo(0));
        }
        
        [Test]
        public void Example2()
        {
            var day9 = new Day9Part1("<random characters>");
            Assert.That(day9.GetGarbageCount(), Is.EqualTo(17));
        }
        
        [Test]
        public void Example3()
        {
            var day9 = new Day9Part1("<<<<>");
            Assert.That(day9.GetGarbageCount(), Is.EqualTo(3));
        }
        
        [Test]
        public void Example4()
        {
            var day9 = new Day9Part1("<{!>}>");
            Assert.That(day9.GetGarbageCount(), Is.EqualTo(2));
        }
        
        [Test]
        public void Example5()
        {
            var day9 = new Day9Part1("<!!>");
            Assert.That(day9.GetGarbageCount(), Is.EqualTo(0));
        }
        
        [Test]
        public void Example6()
        {
            var day9 = new Day9Part1("<!!!>>");
            Assert.That(day9.GetGarbageCount(), Is.EqualTo(0));
        }
        
        [Test]
        public void Example7()
        {
            var day9 = new Day9Part1("<{o\"i!a,<{i<a>");
            Assert.That(day9.GetGarbageCount(), Is.EqualTo(10));
        }
        
        [Test]
        public void Solution()
        {
            var input = File.ReadAllText(@"C:\Dev\AdventOfCode2017\AdventOfCodeTests\Day9\Day9.txt");
            var day9 = new Day9Part1(input);
            Console.WriteLine(day9.GetGarbageCount());
        }
    }
}