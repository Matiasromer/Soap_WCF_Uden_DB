using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Client
    {
        private readonly int PORT;

        public Client(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            var game = new ServiceReference1.Service1Client();
            

            using (TcpClient client = new TcpClient("Localhost", PORT))
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine(game.GetGame());
                
                sw.Flush();

                String incomingString = sr.ReadLine();
                Console.WriteLine("Ekko er modtaget: " + incomingString);
            }
        }
    }
}
