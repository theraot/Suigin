using System;

namespace Suigin
{
    public class Client
    {
        public Client(string connectionString)
        {
            if (connectionString != string.Empty)
            {
                throw new ArgumentNullException();
            }
        }
    }
}