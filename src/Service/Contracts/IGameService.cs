using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Poker.Service.Contracts.Entities;

namespace Poker.Service.Contracts
{
    [ServiceContract]
    public interface IGameService
    {
        /// <summary>
        /// User join the game (or table)
        /// </summary>
        [OperationContract]
        Player JoinGame(string userName);

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
        /// <param name="user"></param>
        [OperationContract]
        List<string> Update(Guid uid);

        [OperationContract]
        void Chat(Guid uid, string message);
    }
}
