using System;
using Metaphor;
using Xunit;

namespace MetaphorTest
{
    public class ItemPickerTest
    {
        [Fact]
        public void ConstructorThrowsOnNullCallback()
        {
            Assert.Throws<ArgumentNullException>(() => new ItemPicker<int>(randomCallback: null, validItems: new int[] { }));
        }

        [Fact]
        public void ConstructorThrowsOnNullCharArray()
        {
            void RandomCallback(byte[] buffer) { }
            Assert.Throws<ArgumentNullException>(() => new ItemPicker<int>(randomCallback: RandomCallback, validItems: null));
        }

        [Fact]
        public void ConstructorValidInput()
        {
            void RandomCallback(byte[] buffer) { }
            var randomString = new ItemPicker<int>(randomCallback: RandomCallback, validItems: new int[] { });
            Assert.NotNull(randomString);
        }
    }
}