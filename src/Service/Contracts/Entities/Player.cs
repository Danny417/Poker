using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Service.Contracts.Entities
{
    /// <summary>
    /// Data model that represents a player
    /// </summary>
    [DataContract]
    public class Player
    {
        #region Fields
        private List<string> _messages;
        private List<Card> _startingCards;

        #endregion

        #region Data Members
        [DataMember]
        public Guid UniqueIdentifier { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public List<Card> StartingCards { get; private set; }

        /// <summary>
        /// Demo purpose
        /// </summary>
        [DataMember]
        public List<string> Messages { 
            get { return _messages ?? (_messages = new List<string>()); }
            set { _messages = value; } 
        }

        /// <summary>
        /// Demo purpose
        /// </summary>
        [DataMember]
        public int State { get; set; }
        #endregion
    }
}
