using System;

namespace Metaphor
{
    public class CharacterPicker
    {
        public CharacterPicker(Action<byte[]> randomCallback, char[] validCharacters)
        {
            if (validCharacters == null)
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