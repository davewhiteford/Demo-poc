using NUnit.Framework;
using System;

namespace MusicLibrary.Tests
{
    [TestFixture]
    public class PlainTest
    {
        [Test]
        public void IsTrue_Yes() 
        {
            var isTrue = true;
            Assert.AreEqual(isTrue, true);
        }
    }
}
