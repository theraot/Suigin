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
            Assert.Throws<ArgumentNullException>(() => new CharacterPicker(randomCallback: null, validCharacters: new char[] { }));
        }

        [Fact]
        public void ConstructorThrowsOnNullCharArray()
        {
            void RandomCallback(byte[] buffer) { }
            Assert.Throws<ArgumentNullException>(() => new CharacterPicker(randomCallback: RandomCallback, validCharacters: null));
        }

        [Fact]
        public void ConstructorValidInput()
        {
            void RandomCallback(byte[] buffer) { }
            var randomString = new CharacterPicker(randomCallback: RandomCallback, validCharacters: new char[] { });
            Assert.NotNull(randomString);
        }
    }
}