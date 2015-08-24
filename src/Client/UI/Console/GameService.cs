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
        void IGameManagerCallback.CatchError(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }

        void IGameManagerCallback.HasJoinedGame(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }

        void IGameManagerCallback.HasQuitGame(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }

        void IGameManagerCallback.HasWatchedGame(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }
    }
}
