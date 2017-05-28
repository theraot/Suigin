using System;
using Metaphor;
using Xunit;

namespace MetaphorTest
{
    public class RandomStringTest
    {
        [Fact]
        public void HasConstructorTakingStringAndRandomCallback()
        {
            var random = new Random();
            var randomString = new RandomString(validCharacters: string.Empty, randomCallback: random.NextBytes);
            Assert.NotNull(randomString);
        }
    }
}