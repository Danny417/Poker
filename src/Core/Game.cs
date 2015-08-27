using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Diagnostics;
using Poker.Service.Contracts;
using Poker.Service.Contracts.Entities;

namespace Poker.Core
{
    /// <summary>
    /// Implementation of IGameManager which handles how client join, quit, and watch a game
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Game : IGameManager
    {
        #region Private members
        private EventLog _eventLog;
        private Dictionary<Guid, IGameService> _clients;
        #endregion

        #region Public Properties

        public IGameService Proxy
        {
            get { return OperationContext.Current.GetCallbackChannel<IGameService>(); }
        }

        #endregion

        #region Constructor
        
        /// <summary>
        /// Game constructor
        /// </summary>
        public Game()
        {
            _clients = new Dictionary<Guid, IGameService>();
            _eventLog = new System.Diagnostics.EventLog
            {
                Source = "PokerSource",
                Log = "PokerServiceLog"
            };
        }
        #endregion

        #region IGameServiceManager Members
       
        /// <summary>
        /// User joins the game with table number and user information
        /// </summary>
        /// <param name="user">user object contains table number and user information</param>
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

        /// <summary>
        /// User quits the game with the table number and user information
        /// </summary>
        /// <param name="user">user object contains table number and user information</param>
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

        /// <summary>
        /// User joins to watch the game
        /// </summary>
        /// <param name="user">user object contains table number and user information</param>
        public void WatchGame(Player user)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
