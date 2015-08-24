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
                _clients.Add(user.UniqueIdentifier, Proxy);
                foreach(var callbackService in _clients.Values)
                {
                    callbackService.HasJoinedGame(new GameResponse(true, user.UserName + " has joined the game."));
                }
                
            }
            catch (Exception ex)
            {
                Proxy.HasJoinedGame(new GameResponse(false, ex.Message));
            }
            
        }

        public void QuitGame(Player user)
        {
            try
            {
                _clients.Remove(user.UniqueIdentifier);
                Proxy.HasQuitGame(new GameResponse(true, "You have quited the game."));
                foreach (var callbackService in _clients.Values)
                {
                    callbackService.HasQuitGame(new GameResponse(true, user.UserName + " has quited the game."));
                }

            }
            catch (Exception ex)
            {
                Proxy.HasJoinedGame(new GameResponse(false, ex.Message));
            }
        }

        public void WatchGame(Player user)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
