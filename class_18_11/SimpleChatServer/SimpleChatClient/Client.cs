using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChatClient
{
    public class Client
    {
        //Two ways to implement a (TCP) Client
        //TcpClient
        //Socket
        Socket clientSocket;
        byte[] buffer = new byte[256];
        public Client(int port)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(new IPEndPoint(IPAddress.Loopback, port));
        
        }

        public void SendData(string message)
        {
            clientSocket.Send(Encoding.UTF8.GetBytes(message));
        }

        
        public string ReceiveData()
        {
            string message = "";
            int length;
            while (!message.Contains("\r\n"))
            {
                length = clientSocket.Receive(buffer);
                message += Encoding.UTF8.GetString(buffer, 0, length);
            }
            return message;
        }
    }
}
