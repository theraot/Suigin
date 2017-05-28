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
            var random = new Random();
            Assert.Throws<ArgumentNullException>(() => new RandomString(validCharacters: string.Empty, randomCallback: null));
        }

        [Fact]
        public void ConstructorThrowsOnNullString()
        {
            var random = new Random();
            Assert.Throws<ArgumentNullException>(() => new RandomString(validCharacters: null, randomCallback: random.NextBytes));
        }
    }
}