using System;

namespace Metaphor
{
    public class RandomString
    {
        public RandomString(string validCharacters, Action<byte[]> randomCallback)
        {
            if (validCharacters != string.Empty)
            {
                throw new ArgumentNullException(nameof(validCharacters));
            }
            GC.KeepAlive(randomCallback);
        }
    }
}