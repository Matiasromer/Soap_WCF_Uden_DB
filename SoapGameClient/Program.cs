using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapGameClient.ServiceReference1;

namespace SoapGameClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client client = new Service1Client())
            {
                Game[] ListOfGames = client.GetGame();
                foreach (var gam in ListOfGames)
                {
                    Console.WriteLine(gam.Titel + " " + gam.Rating);
                }
            }

            Console.ReadLine();
        }
    }
}
