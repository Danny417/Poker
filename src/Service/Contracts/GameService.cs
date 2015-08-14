using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Service.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GameService : IGameService
    {
        private List<string> users; 

        public GameService()
        {
            users = new List<string>();
        }
        #region IGameService Members
        /// <summary>
        /// even trigger when a client is connected to the service
        /// </summary>
        /// <param name="userName">name of client that connects to the service</param>
        public List<string> JoinGame(string userName)
        {
            var eventLog1 = new System.Diagnostics.EventLog
            {
                Source = "PokerSource",
                Log = "PokerServiceLog"
            };

            users.Add(userName);

            eventLog1.WriteEntry(userName + " has joined the game.");

            return users;
        }

        /// <summary>
        /// 
        /// </summary>
        public void QuitGame()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void WatchGame()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
