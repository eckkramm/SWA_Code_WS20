using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace VmRequestor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Establish connection to Server
            //Query Vm Data from user
            //send data to Server
            TcpClient client = new TcpClient();
            //connect 
            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10100));
            while (true)
            {
                #region boring stuff
                Console.WriteLine("Please enter type of resource: [Vm|Container]:");
                string type = Console.ReadLine();

                Console.WriteLine("Please enter amount of RAM: [GB]:");
                string ram = Console.ReadLine();

                Console.WriteLine("Please enter amount of CPUs:");
                string cpuCount = Console.ReadLine();

                Console.WriteLine("Please enter amount of storage: [TB]:");
                string storage = Console.ReadLine();
                //TODO: do some data validation
                //string message = type + "@" + ram + "@" + cpuCount + "@" + storage;
                string message = $"{type}@{ram}@{cpuCount}@{storage}";

                client.Client.Send(Encoding.UTF8.GetBytes(message));
                Console.WriteLine("------------------------");
                #endregion 
            }
        }
    }
}
