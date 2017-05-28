using System;

namespace Metaphor
{
    public class RandomString
    {
        public RandomString(string validCharacters)
        {
            GC.KeepAlive(validCharacters);
        }
    }
}