using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleChatServer
{
    public class Server
    {
        Socket serverSocket;
        List<ClientHandler> clients = new List<ClientHandler>();
        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10100));
            serverSocket.Listen(5);
            Task.Factory.StartNew(AcceptClients);
            //other methods to realize threads
            //ThreadPool.QueueUserWorkItem()
            //Thread th = new Thread(new ThreadStart('method to call via delegate'));
            //async await
            //Begin... und End.. Pattern 
            Console.WriteLine("Start Accepting...");
        }

        private void AcceptClients()
        {
            while (true)
            {
                clients.Add(new ClientHandler(serverSocket.Accept()));
                Console.WriteLine("New Client Accepted");
            }
        }
    }
}
