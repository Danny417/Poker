using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Core
{
    public class Card
    {
        public CardRank Rank { get; private set; }
        public CardRank Suit { get; private set; }

        // TODO: We might not use this at all
        int Score
        {
            get
            {
                return 0;
                //return Rank * 4 + Suit;
            }
        }
    }

    public enum CardRank
    {
        Ace = 14,
        King = 13,
        Queen = 12,
        Jack = 11,
        r10 = 10,
        r9 = 9,
        r8 = 8,
        r7 = 7,
        r6 = 6,
        r5 = 5,
        r4 = 4,
        r3 = 3,
        r2 = 2,
    }

    public enum CardSuit
    {
        Spade = 4,
        Heart = 3,
        Diamond = 2,
        Club = 1,
    }
}
