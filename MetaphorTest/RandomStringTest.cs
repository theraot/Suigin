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
            Assert.Throws<ArgumentNullException>(() => new RandomString(randomCallback: null, validCharacters: string.Empty));
        }

        [Fact]
        public void ConstructorThrowsOnNullString()
        {
            void RandomCallback(byte[] buffer) { }
            Assert.Throws<ArgumentNullException>(() => new RandomString(randomCallback: RandomCallback, validCharacters: null));
        }
    }
}