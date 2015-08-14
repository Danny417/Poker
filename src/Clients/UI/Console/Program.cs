using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker.Clients.UI.Console.GameServiceReference;
using Poker.Core;

namespace Poker.Clients.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // We don't need these anymore as game components do not execute on client side
            // In other words, client does not have control how game is running
          
            /*ITable gameTable = new Table();
            List<IPlayer> playersInTheGame = new List<IPlayer>();
            // Add two players
            playersInTheGame.Add(new SampleAiPlayer(gameTable));
            playersInTheGame.Add(new SampleAiPlayer(gameTable));
            // Start the game
            gameTable.StartNewGame(playersInTheGame);*/


            //DEMO
            GameServiceClient gameClient =
                new GameServiceClient("NetTcpBinding_IGameService");

            System.Console.WriteLine("Hello! Please enter your name.");
            var userName = System.Console.ReadLine();
            var msg = String.Empty;
            var users = gameClient.JoinGame(userName);

            foreach (var user in users)
            {
                System.Console.WriteLine("{0} has joined the game.", user);
            }

            System.Console.ReadLine();

        }
    }
}
