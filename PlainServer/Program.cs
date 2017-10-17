﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlainServer
{
    class Program
    {
        private const int port = 1001;

        static void Main(string[] args)
        {
            Server server = new Server(port);
            server.StartServer();

            Console.ReadLine();

        }
    }
}
