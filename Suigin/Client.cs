using System;

namespace Suigin
{
    public class Client
    {
        public Client(string connectionString)
        {
            GC.KeepAlive(connectionString);
            throw new ArgumentNullException();
        }
    }
}