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
        /// 
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void HasJoinedGame(GameResponse res);

        /// <summary>
        /// 
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void HasWatchedGame(GameResponse res);

        [OperationContract(IsOneWay = true)]
        void HasQuitGame(GameResponse res);

        /// <summary>
        /// 
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void CatchError(GameResponse res);
        
    }
}
