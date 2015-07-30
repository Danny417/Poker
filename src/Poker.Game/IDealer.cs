using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Game
{
    public interface IDealer
    {
        /// <summary>
        /// Creates a new, shuffled deck
        /// </summary>
        void GetNewDeck();

        Card Deal();
    }
}
