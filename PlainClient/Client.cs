using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TcpFormatEchoTech;


namespace PlainClient
{
    internal class Client
    {
        private readonly int port;

        public Client(int port)
        {
            this.port = port;
        }


        public void StratClient()
        {
            Car car = new Car("Tesla", "red", "EL23400");

            using (TcpClient cSocket = new TcpClient("localhost", port))
            using (Stream stream = cSocket.GetStream())
            using (StreamWriter toServer = new StreamWriter (stream))
            {
                toServer.WriteLine(car.ToString());
                toServer.Flush();
            }
                
            
        }
    }
}
