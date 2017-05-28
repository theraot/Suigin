using System;
using Metaphor;
using Xunit;

namespace MetaphorTest
{
    public class RandomStringTest
    {
        [Fact]
        public void ConstructorThrowsOnNullCallback()
        {
            Assert.Throws<ArgumentNullException>(() => new RandomString(validCharacters: string.Empty, randomCallback: null));
        }

        [Fact]
        public void ConstructorThrowsOnNullString()
        {
            void RandomCallback(byte[] buffer) { }
            Assert.Throws<ArgumentNullException>(() => new RandomString(validCharacters: null, randomCallback: RandomCallback));
        }
    }
}