using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using Poker.Service.Contracts;
using Poker.Service.Contracts.Entities;

namespace Poker.Core
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Game : IGameManager
    {
        private EventLog _eventLog;
        private Dictionary<Guid, IGameService> _clients;

        #region Public Properties

        public IGameService Proxy => OperationContext.Current.GetCallbackChannel<IGameService>();

        #endregion
        public Game()
        {
            _clients = new Dictionary<Guid, IGameService>();
            _eventLog = new System.Diagnostics.EventLog
            {
                Source = "PokerSource",
                Log = "PokerServiceLog"
            };
        }

        #region IGameServiceManager Members
       
        public void JoinGame(Player user)
        {
            try
            {
                IGameService client = Proxy;
                _clients.Add(user.UniqueIdentifier, Proxy);
                client.HasJoinedGame(new GameResponse(true, user.UserName + " has successfully joined the game."));
            } catch(Exception ex)
            {
                Proxy.HasJoinedGame(new GameResponse(false, ex.Message));
            }
            
        }

        public void QuitGame(Player user)
        {
            throw new NotImplementedException();
        }

        public void WatchGame(Player user)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
