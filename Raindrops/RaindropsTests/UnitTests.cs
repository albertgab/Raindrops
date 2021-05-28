using NUnit.Framework;
using System;

namespace RaindropsTests
{
    
    public class Tests
    {
        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]
        public void InputANumber_ExpectedStringReturned (int n, string exp)
        {
            Assert.That(Raindrops.Raindrops.GetRaindrops(n), Is.EqualTo(exp));
        }
    }
}