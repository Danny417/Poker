using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Poker.Service.Contracts.Entities;

namespace Poker.Service.Contracts
{
    [ServiceContract(CallbackContract = typeof(IGameService))]
    public interface IGameManager
    {
        /// <summary>
        /// User joins the game with table number and user information
        /// </summary>
        /// <param name="user">user object contains table number and user information</param>
        [OperationContract(IsOneWay = true)]
        void JoinGame(Player user);

        /// <summary>
        /// User quits the game with the table number and user information
        /// </summary>
        /// <param name="user">user object contains table number and user information</param>
        [OperationContract(IsOneWay = true)]
        void QuitGame(Player user);

        /// <summary>
        /// User joins to watch the game
        /// </summary>
        /// <param name="user">user object contains table number and user information</param>
        [OperationContract(IsOneWay = true)]
        void WatchGame(Player user);
    }
}
