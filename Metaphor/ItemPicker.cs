using System;

namespace Metaphor
{
    public class ItemPicker<T>
    {
        public ItemPicker(Action<byte[]> randomCallback, T[] validItems)
        {
            if (validItems == null)
            {
                throw new ArgumentNullException(nameof(validItems));
            }
            if (randomCallback == null)
            {
                throw new ArgumentNullException(nameof(randomCallback));
            }
        }
    }
}