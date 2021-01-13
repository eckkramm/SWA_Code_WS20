using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace VmResourceManagerServer.Communication
{
    /// <summary>
    /// Handles the COmmunication requests from Clients till Handshake with client
    /// </summary>
    class Server
    {
        private List<ClientHandler> clients = new List<ClientHandler>();
        private Action<string> action;
        TcpListener tcpListener;
        //use TCP Listener or Socket 
        public Server(string ip, int port, Action<string> action)
        {
            this.action = action;
            tcpListener = new TcpListener(IPAddress.Parse(ip), port);
            tcpListener.Start();
            Task.Factory.StartNew(StartAccepting);


        }

        private void StartAccepting()
        {
            while (true)
            {
                clients.Add(new ClientHandler(tcpListener.AcceptSocket(), action));

            }
        }
    }
}
