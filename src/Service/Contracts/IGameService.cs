using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Service.Contracts
{
    [ServiceContract]
    public interface IGameService
    {
        /// <summary>
        /// User join the game (or table)
        /// </summary>
        [OperationContract]
        Guid JoinGame(string userName);

        /// <summary>
        /// User leave the game
        /// </summary>
        [OperationContract]
        void QuitGame();

        /// <summary>
        /// 
        /// </summary>
        [OperationContract]
        void WatchGame();

        /// <summary>
        /// update client with list of users
        /// </summary>
        /// <param name="uid"></param>
        /// <returns>users' names</returns>
        [OperationContract]
        List<String> update(Guid uid);
    }
}
