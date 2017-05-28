using Metaphor;
using Xunit;

namespace MetaphorTest
{
    public class RandomStringTest
    {
        [Fact]
        public void HasConstructorTakingString()
        {
            var randomString = new RandomString(validCharacters: string.Empty);
            Assert.NotNull(randomString);
        }
    }
}