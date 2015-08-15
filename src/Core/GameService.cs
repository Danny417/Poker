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
    public class GameService : IGameService
    {
        private List<string> _sysMessages;
        private EventLog _eventLog;
        private Dictionary<Guid, Player> _users; 

        public GameService()
        {
            _sysMessages = new List<string>();
            _users = new Dictionary<Guid, Player>();
            _eventLog = new System.Diagnostics.EventLog
            {
                Source = "PokerSource",
                Log = "PokerServiceLog"
            };
        }

        #region IGameService Members
        /// <summary>
        /// even trigger when a client is connected to the service
        /// </summary>
        /// <param name="userName">the user object</param>
        public Player JoinGame(string userName)
        {
            _sysMessages.Add(userName + " has joined the game.");
            var user = new Player
            {
                UserName = userName,
                UniqueIdentifier = Guid.NewGuid(),
                State = _sysMessages.Count
            };
            _users.Add(user.UniqueIdentifier, user);
            return user;
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

        /// <summary>
        /// Demo puprpose, this method update client with new messages
        /// </summary>
        /// <param name="uid">client user</param>
        public List<string> Update(Guid uid)
        {
            var ret = new List<string>();
            try
            {
                var newMsgCount = _sysMessages.Count - _users[uid].State;
                if (newMsgCount > 0)
                {
                    ret.AddRange(_sysMessages.GetRange(_users[uid].State, newMsgCount));
                }
                _users[uid].State = _sysMessages.Count;
            }
            catch (Exception nre)
            {
                EventLog.WriteEntry(nre.Source, nre.Message);
            }
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="message"></param>
        public void Chat(Guid uid, string message)
        {
            _users[uid].State = _sysMessages.Count + 1;
            _sysMessages.Add(_users[uid].UserName + " says : " + message);
        }
        #endregion
    }
}
