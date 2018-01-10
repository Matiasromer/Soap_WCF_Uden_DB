using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Soap_WCF_Uden_DB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Game> GetGame();

        [OperationContract]
        Game GetOneGame(string id);
        [OperationContract]
        void AddGame(Game newGame);

        [OperationContract]
        void DeleteGame(Game deleteGame);

        [OperationContract]
        void UpdateGame(int id, Game game);



        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
}
