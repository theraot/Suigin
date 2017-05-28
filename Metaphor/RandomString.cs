using System;

namespace Metaphor
{
    public class RandomString
    {
        public RandomString(string validCharacters, Action<byte[]> randomCallback)
        {
            GC.KeepAlive(validCharacters);
            GC.KeepAlive(randomCallback);
        }
    }
}