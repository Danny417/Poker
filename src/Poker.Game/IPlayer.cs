using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker.Game
{
    public interface IPlayer
    {
        void MakeMove();

        void ObserveMove();

        void ObserveGameState(ITable table);

        void RevealHand();

        void AcceptCard(Card card);
    }
}
