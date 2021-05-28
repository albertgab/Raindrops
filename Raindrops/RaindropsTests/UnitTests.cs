using NUnit.Framework;
using System;

namespace RaindropsTests
{
    
    public class Tests
    {
        // Given examples
        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]

        // Boundary values
        [TestCase(Int32.MaxValue, "2147483647")]
        [TestCase(Int32.MinValue, "-2147483648")]
        [TestCase(0, "PlingPlangPlong")]
        public void InputANumber_ExpectedStringReturned (int n, string exp)
        {
            Assert.That(Raindrops.Raindrops.GetRaindrops(n), Is.EqualTo(exp));
        }
    }
}