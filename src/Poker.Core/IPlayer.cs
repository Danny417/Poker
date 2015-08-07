using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Core
{
    public interface IPlayer
    {
        Move MakeMove();

        void ObserveMove();

        void ObserveGameState(); 

        IEnumerable<Card> RevealHand();

        void AcceptCard(Card card);
    }
}
