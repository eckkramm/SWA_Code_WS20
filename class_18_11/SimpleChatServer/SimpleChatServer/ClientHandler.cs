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
        //TODO: Save Name info
        string name = "";

        public ClientHandler(Socket sock)
        {
            clientSocket = sock;
            //TODO: Send Name info request
            clientSocket.Send(Encoding.UTF8.GetBytes("Hello new Client! - ready to receive data...\r\n Please enter your name \r\n"));
            Task.Factory.StartNew(Receive);
        }

        private void Receive()
        {
            int length;
            string message = "";

            //TODO: extract name from first receive 
            while (!name.Contains("\r\n"))
            {
                length = clientSocket.Receive(buffer);
                name += Encoding.UTF8.GetString(buffer, 0, length);
            }
            name = name.Replace("\r\n", "");
            while (true)
            {
                length = clientSocket.Receive(buffer);
                message += Encoding.UTF8.GetString(buffer, 0, length);
                if (message.Contains("\r\n"))
                {
                    //TODO: Add Name info to message output
                    Console.Write(name + ": " + message);
                    message = "";
                }
            }
        }

    }
}
