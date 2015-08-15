using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Service.Contracts.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Table
    {
        #region Protected Fields
        protected Stack<Card> _deck;
        protected List<Player> _players;

        #endregion

        #region Data Members
        [DataMember]
        public Stack<Card> Deck {
            get { return _deck; }
            protected set { this._deck = value; }
        }

        [DataMember]
        public IEnumerable<Player> Players
        {
            get { return _players; }
            protected set { this._players.AddRange(value);  }
        }

        #endregion
    }
}
