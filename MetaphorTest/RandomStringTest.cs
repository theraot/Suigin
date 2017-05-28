﻿using System;
using Metaphor;
using Xunit;

namespace MetaphorTest
{
    public class RandomStringTest
    {
        [Fact]
        public void ConstructorThrowsOnNullCallback()
        {
            Assert.Throws<ArgumentNullException>(() => new RandomString(randomCallback: null, validCharacters: new char[] { }));
        }

        [Fact]
        public void ConstructorThrowsOnNullCharArray()
        {
            void RandomCallback(byte[] buffer) { }
            Assert.Throws<ArgumentNullException>(() => new RandomString(randomCallback: RandomCallback, validCharacters: null));
        }
    }
}