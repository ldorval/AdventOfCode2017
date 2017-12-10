

using System;
using System.IO;
using AdventOfCode;
using NUnit.Framework;

namespace AdventOfCodeTests
{
    [TestFixture]
    public class Day9Part1Test
    {
        [Test]
        public void Example1()
        {
            var day9 = new Day9Part1("{}");
            Assert.That(day9.GetScore(), Is.EqualTo(1));
        }
        
        [Test]
        public void Example2()
        {
            var day9 = new Day9Part1("{{{}}}");
            Assert.That(day9.GetScore(), Is.EqualTo(6));
        }
        
        [Test]
        public void Example3()
        {
            var day9 = new Day9Part1("{{},{}}");
            Assert.That(day9.GetScore(), Is.EqualTo(5));
        }
        
        [Test]
        public void Example4()
        {
            var day9 = new Day9Part1("{{{},{},{{}}}}");
            Assert.That(day9.GetScore(), Is.EqualTo(16));
        }
        
        [Test]
        public void Example5()
        {
            var day9 = new Day9Part1("{<a>,<a>,<a>,<a>}");
            Assert.That(day9.GetScore(), Is.EqualTo(1));
        }
        
        [Test]
        public void Example6()
        {
            var day9 = new Day9Part1("{{<ab>},{<ab>},{<ab>},{<ab>}}");
            Assert.That(day9.GetScore(), Is.EqualTo(9));
        }
        
        [Test]
        public void Example7()
        {
            var day9 = new Day9Part1("{{<!!>},{<!!>},{<!!>},{<!!>}}");
            Assert.That(day9.GetScore(), Is.EqualTo(9));
        }
        
        [Test]
        public void Example8()
        {
            var day9 = new Day9Part1("{{<a!>},{<a!>},{<a!>},{<ab>}}");
            Assert.That(day9.GetScore(), Is.EqualTo(3));
        }
        
        [Test]
        public void Example9()
        {
            var day9 = new Day9Part1("{<<<<<>}");
            Assert.That(day9.GetScore(), Is.EqualTo(1));
        }

        [Test]
        public void Solution()
        {
            var input = File.ReadAllText(@"C:\Dev\AdventOfCode2017\AdventOfCodeTests\Day9\Day9.txt");
            var day9 = new Day9Part1(input);
            Console.WriteLine(day9.GetScore());
        }
    }
}