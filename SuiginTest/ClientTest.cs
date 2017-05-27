using System;
using System.Collections.Generic;
using Suigin;
using Xunit;

namespace SuiginTest
{
    public class ClientTest
    {
        [Fact]
        public void ConstructorThrowsOnNullString()
        {
            Assert.Throws<ArgumentNullException>(() => new Client(connectionString: null));
        }

        [Theory, MemberData(nameof(ValidConnectionString))]
        public void ConstructorWorksOnValidConnectionString(string connectionString)
        {
            var client = new Client(connectionString: connectionString);
            Assert.NotNull(client);
        }

        [Fact]
        public void HasConstructorTakingString()
        {
            var client = new Client(connectionString: string.Empty);
            Assert.NotNull(client);
        }

        private static IEnumerable<string> ValidConnectionString()
        {
            yield break;
        }
    }
}