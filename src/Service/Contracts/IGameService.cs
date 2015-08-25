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
        /// Response on client's attempt to join the game
        /// </summary>
        /// <param name="res">Response with success or failure message</param>
        [OperationContract(IsOneWay = true)]
        void HasJoinedGame(GameResponse res);

        /// <summary>
        /// Response on client's attempt to watch the game
        /// </summary>
        /// <param name="res">Response with success or failure message</param>
        [OperationContract(IsOneWay = true)]
        void HasWatchedGame(GameResponse res);

        /// <summary>
        /// Response on client's attempt to quit the game
        /// </summary>
        /// <param name="res">Response with success or failure message</param>
        [OperationContract(IsOneWay = true)]
        void HasQuitGame(GameResponse res);

        /// <summary>
        /// System error message display to client
        /// </summary>
        /// <param name="res">Response error message</param>
        [OperationContract(IsOneWay = true)]
        void CatchError(GameResponse res);
        
    }
}
