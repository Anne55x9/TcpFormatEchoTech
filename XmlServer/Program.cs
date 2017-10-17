﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlServer
{
    class Program
    {
        private const int port = 1002;
        static void Main(string[] args)
        {
            Server server = new Server(port);
            server.StartServer();

            Console.ReadLine();

        }
    }
}
