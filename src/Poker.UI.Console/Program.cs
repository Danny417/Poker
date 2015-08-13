using Poker.Core;
using System;
using System.Collections.Generic;
using Poker.Main;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Client.Console
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
