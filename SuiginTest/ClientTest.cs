using System;
using Suigin;
using Xunit;

namespace SuiginTest
{
    public class ClientTest
    {
        [Fact]
        public void HasConstructorTakingString()
        {
            var client = new Client(connectionString: string.Empty);
            Assert.NotNull(client);
        }

        [Fact]
        public void ConstructorThrowsOnNullString()
        {
            Assert.Throws<ArgumentNullException>(() => new Client(connectionString: null));
        }
    }
}