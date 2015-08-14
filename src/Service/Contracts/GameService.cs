using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Poker.Service.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GameService : IGameService
    {
        private OrderedDictionary _users;
        private Dictionary<Guid, int> _states;
        private int _currentState;

        public GameService()
        {
            _users = new OrderedDictionary();
            _states = new Dictionary<Guid, int>();
            _currentState =-1;
        }

        #region IGameService Members
        /// <summary>
        /// even trigger when a client is connected to the service
        /// </summary>
        /// <param name="userName">name of client that connects to the service</param>
        /// <return>unique identifier for the client</return>
        public Guid JoinGame(string userName)
        {
            var eventLog1 = new System.Diagnostics.EventLog
            {
                Source = "PokerSource",
                Log = "PokerServiceLog"
            };

            Guid uid = Guid.NewGuid();
            _users.Add(uid, userName);
            _states.Add(uid, _currentState);
            _currentState += 1;
            eventLog1.WriteEntry(userName + " has joined the game.");

            return uid;
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
        /// Demo puprpose, this method update client with game states
        /// </summary>
        /// <param name="uid">client uid</param>
        /// <returns>users that have joined the game after client's last update</returns>
        public List<string> update(Guid uid)
        {
            int clientState = 0;
            int count = 0;
            _states.TryGetValue(uid, out clientState);
            if (clientState >= _currentState)
            {
                return new List<string>();
            }
            var ret = new List<string>();
            foreach (DictionaryEntry de in _users)
            {
                if (count > clientState)
                {
                    ret.Add(de.Value.ToString());
                }
                count++;
            }
            _states[uid] = _currentState;
            return ret;
        }

        #endregion
    }
}
