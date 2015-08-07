using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Core
{
    public interface ITable
    {
        /// <summary>
        /// Starts a new game with a shuffled deck
        /// </summary>
        /// <param name="players"></param>
        void StartNewGame(IEnumerable<IPlayer> players);

        IEnumerable<IPlayer> GetPlayers();

        IEnumerable<Card> GetVisibleCards();

        object GetGameLog();
    }
}
