﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Service.Contracts.Entities
{
    [DataContract]
    public class Card
    {
        #region Data Members
        [DataMember]
        public CardRank Rank { get; private set; }
        [DataMember]
        public CardSuit Suit { get; private set; }

        #endregion

        /// <summary>
        /// TODO: documentation
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suit"></param>
        public Card(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        #region Override Methods
        /// <summary>
        /// TODO: documentation
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Card)
            {
                return Rank == ((Card)obj).Rank && Suit == ((Card)obj).Suit;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// TODO: documentation
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (int)Rank + (int)Suit * 14;
        }

        /// <summary>
        /// TODO: documentation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "{Rank} of {Suit}s";
        }
        #endregion
    }

    public enum CardRank
    {
        Ace = 14,
        King = 13,
        Queen = 12,
        Jack = 11,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2,
    }

    public enum CardSuit
    {
        Spade = 3,
        Heart = 2,
        Diamond = 1,
        Club = 0,
    }
}
