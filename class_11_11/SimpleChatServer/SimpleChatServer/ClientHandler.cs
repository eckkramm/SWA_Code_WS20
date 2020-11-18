using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChatServer
{
    public class ClientHandler
    {
        byte[] buffer = new byte[256];
        Socket clientSocket;

        public ClientHandler(Socket sock)
        {
            clientSocket = sock;
            clientSocket.Send(Encoding.UTF8.GetBytes("Hello new Client! - ready to receive data...\r\n"));
            Task.Factory.StartNew(Receive);
        }

        private void Receive()
        {
            int length;
            string message = "";
            while (true)
            {
                length = clientSocket.Receive(buffer);
                message += Encoding.UTF8.GetString(buffer, 0, length);
                if (message.Contains("\r\n"))
                {
                    Console.Write(message);
                    message = "";
                }
            }
        }

    }
}
