using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Service.Contracts.Entities;

namespace Poker.Core
{
    public interface IPlayer
    {
        Move MakeMove();

        void ObserveMove();

        void ObserveGameState(); 

        /// <summary>
        /// Shows the two starting cards
        /// </summary>
        /// <returns></returns>
        IEnumerable<Card> RevealHand();

        /// <summary>
        /// Shows the best five card hand this player has
        /// </summary>
        /// <returns></returns>
        IEnumerable<Card> RevealPlayingHand();

        void AcceptCard(Card card);
    }
}
