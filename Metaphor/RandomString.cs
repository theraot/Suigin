using System;

namespace Metaphor
{
    public class RandomString
    {
        public RandomString(Action<byte[]> randomCallback, string validCharacters)
        {
            if (validCharacters != string.Empty)
            {
                throw new ArgumentNullException(nameof(validCharacters));
            }
            if (randomCallback == null)
            {
                throw new ArgumentNullException(nameof(randomCallback));
            }
        }
    }
}