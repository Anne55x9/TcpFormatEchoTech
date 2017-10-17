using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TcpFormatEchoTech;

namespace JsonClient
{
    internal class Client
    {
        private int port;

        public Client(int port)
        {
            this.port = port;
        }

        public void StartClient()
        {
            Car car = new Car("Tesla", "Green", "ab12345");

            using (TcpClient cSocket = new TcpClient("localhost",port))
            using (Stream stream = cSocket.GetStream())
            using (StreamWriter toServer = new StreamWriter(stream))
            {
                string jsonStr = JsonConvert.SerializeObject(car);
                Console.WriteLine($"Client json string: {jsonStr} and size:: {jsonStr.Length}");

                toServer.WriteLine(jsonStr);
                toServer.Flush();
            }
                
            
                
            
        }
    }
}
