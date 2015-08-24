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
            
        [OperationContract(IsOneWay = true)]
        void JoinGame(Player user);

        /// <summary>
        /// User leave the game
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void QuitGame(Player user);

        /// <summary>
        /// 
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void WatchGame(Player user);
    }
}
