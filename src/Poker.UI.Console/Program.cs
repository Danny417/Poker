using Poker.Core;
using Poker.GameImplementation1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ITable gameTable = new Table();
            List<IPlayer> playersInTheGame = new List<IPlayer>();
            // Add two players
            playersInTheGame.Add(new SampleAiPlayer(gameTable));
            playersInTheGame.Add(new SampleAiPlayer(gameTable));
            // Start the game
            gameTable.StartNewGame(playersInTheGame);
        }
    }
}
