using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlClient
{
    class Program
    {
        private const int port = 1002;
        static void Main(string[] args)
        {
            Client client = new Client(port);
            client.StartClient();

            Console.ReadLine();
        }
    }
}
