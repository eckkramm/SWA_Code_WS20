using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
