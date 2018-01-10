using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Soap_WCF_Uden_DB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        static List<Game> ListOfGames = new List<Game>()
        {
            new Game() {Id=1, Titel="Call of Duty", Rating=5.6},
            new Game() {Id=2, Titel="Battlefield 1942", Rating=7.5},
            new Game() {Id=3, Titel="Battlefront 2", Rating=9.2},

            
        };
        public void AddGame(Game newGame)
        {
            ListOfGames.Add(newGame);
        }

        public void DeleteGame(Game deleteGame)
        {
            var game = ListOfGames.Find(gam => gam.Id == deleteGame.Id);
            ListOfGames.Remove(game);
        }

        public List<Game> GetGame()
        {
            return ListOfGames;
        }

        public Game GetOneGame(string id)
        {
            int idint = Int32.Parse(id);

            return ListOfGames.Find(c => c.Id == idint);
        }

        public void UpdateGame(int id, Game game)
        {
            var nyGame = ListOfGames.Find(gam => gam.Id == game.Id);
            nyGame.Titel = game.Titel;
            nyGame.Rating = game.Rating;

        }
    }
}
