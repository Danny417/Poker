using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Clients.UI.Console.GameServiceReference;

namespace Poker.Clients.UI.Console
{
    public class GameService : IGameManagerCallback
    {
        #region IGameService members
        /// <summary>
        /// System error message display to client
        /// </summary>
        /// <param name="res">Response error message</param>
        void IGameManagerCallback.CatchError(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }

        /// <summary>
        /// Response on client's attempt to join the game
        /// </summary>
        /// <param name="res">Response with success or failure message</param>
        void IGameManagerCallback.HasJoinedGame(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }

        /// <summary>
        /// Response on client's attempt to quit the game
        /// </summary>
        /// <param name="res">Response with success or failure message</param>
        void IGameManagerCallback.HasQuitGame(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }

        /// <summary>
        /// Response on client's attempt to watch the game
        /// </summary>
        /// <param name="res">Response with success or failure message</param>
        void IGameManagerCallback.HasWatchedGame(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }
        #endregion
    }
}
