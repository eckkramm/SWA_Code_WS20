using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace VmResourceManagerServer.Communication
{
    internal class ClientHandler
    {
        private Action<string> action;
        private Socket socket;
        private byte[] buffer = new byte[512];

        public ClientHandler(Socket socket, Action<string> action)
        {
            this.action = action;
            this.socket = socket;
            Task.Factory.StartNew(ReceiveData);
        }

        private void ReceiveData()
        {
            int length;
            while (true)
            {
                length = socket.Receive(buffer);
                string message = Encoding.UTF8.GetString(buffer, 0, length);
                //TODO: send data to the GUI!
                action(message);

            }
        }
    }
}