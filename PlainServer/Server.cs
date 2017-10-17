﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlainServer
{
    internal class Server
    {
        private readonly int port;

        public Server(int port)
        {
            this.port = port;
        }

        public void StartServer()
        {
            TcpListener server = new TcpListener(IPAddress.Any,port);
            server.Start();

            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient socket = clientSocket;
                    DoClient(socket);
                });

            }
        }

        private void DoClient(TcpClient socket)
        {
            using (NetworkStream stream = socket.GetStream())
            using (StreamReader fromClient = new StreamReader(stream))
            {
                string strFromClient = fromClient.ReadLine();
                Console.WriteLine($"From Client text : {strFromClient}");
            }
                
            
        }

    }
}
