using Suigin;
using Xunit;

namespace SuiginTest
{
    public class ClientTest
    {
        [Fact]
        public void HasConstructor()
        {
            var client = new Client();
            Assert.NotNull(client);
        }
    }
}