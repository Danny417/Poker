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
            throw new NotImplementedException();
        }

        void IGameManagerCallback.HasJoinedGame(GameResponse res)
        {
            System.Console.WriteLine(res.Message);
        }

        void IGameManagerCallback.HasQuitGame(GameResponse res)
        {
            throw new NotImplementedException();
        }

        void IGameManagerCallback.HasWatchedGame(GameResponse res)
        {
            throw new NotImplementedException();
        }
    }
}
