using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Game
{
    public interface ITable
    {
        void StartNewGame(IEnumerable<IPlayer> players);

        IEnumerable<IPlayer> GetPlayers();

        IEnumerable<Card> GetVisibleCards();

        int GetCurrentBet();

        int GetMaximumBet();

        int GetMinimumBet();
    }
}
